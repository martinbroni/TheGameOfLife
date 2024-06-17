using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace PlaytoztheGame
{
    public partial class MainForm : Form
    {
        private bool[,] gameGridPlayer1; // Игровое поле для игрока 1
        private bool[,] gameGridPlayer2; // Игровое поле для игрока 2
        private int width = 50; // Ширина игрового поля
        private int height = 50; // Высота игрового поля
        private int cellSize = 10; // Размер клетки
        private Color player1Color = Color.Blue; // Цвет клеток первого игрока
        private Color player2Color = Color.Red; // Цвет клеток второго игрока
        private Color backgroundColor = Color.White; // Цвет фона
        private bool isPlayer1Turn = true; // Переменная для определения очередности игроков
        private System.Timers.Timer gameTimer;
        private int generationInterval = 200; // Интервал между поколениями в миллисекундах

        public MainForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Инициализация игровых полей для обоих игроков
            gameGridPlayer1 = new bool[width, height];
            gameGridPlayer2 = new bool[width, height];

            // Инициализация таймера
            gameTimer = new System.Timers.Timer(generationInterval);
            gameTimer.Elapsed += GameTimer_Elapsed;

            // Отображение начального состояния игры
            UpdateGameUI();
        }

        private void UpdateGameUI()
        {
            // Перерисовка игрового поля
            gamePanel.Invalidate();
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
            // Заливка фона
            e.Graphics.Clear(backgroundColor);

            // Отрисовка клеток для обоих игроков
            DrawPlayerGrid(e.Graphics, gameGridPlayer1, player1Color); // Игрок 1
            DrawPlayerGrid(e.Graphics, gameGridPlayer2, player2Color); // Игрок 2
        }

        private void DrawPlayerGrid(Graphics g, bool[,] gameGrid, Color color)
        {
            Brush brush = new SolidBrush(color);

            // Отрисовка клеток для определённого игрока
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (gameGrid[i, j])
                    {
                        // Рисуем прямоугольник для отображения живой клетки
                        g.FillRectangle(brush, i * cellSize, j * cellSize, cellSize, cellSize);
                    }
                }
            }
        }

        private void GamePanel_MouseClick(object sender, MouseEventArgs e)
        {
            // Получение координат клика
            int xIndex = e.X / cellSize;
            int yIndex = e.Y / cellSize;

            // Проверка границ и обновление состояния клетки
            if (xIndex >= 0 && xIndex < width && yIndex >= 0 && yIndex < height)
            {
                if (isPlayer1Turn)
                {
                    gameGridPlayer1[xIndex, yIndex] = !gameGridPlayer1[xIndex, yIndex]; // Инвертирование состояния клетки для игрока 1
                }
                else
                {
                    gameGridPlayer2[xIndex, yIndex] = !gameGridPlayer2[xIndex, yIndex]; // Инвертирование состояния клетки для игрока 2
                }

                // Переключение хода на следующего игрока
                isPlayer1Turn = !isPlayer1Turn;

                // Обновление отображения
                UpdateGameUI();
            }
        }

        private void Player1ColorButton_Click(object sender, EventArgs e)
        {
            // Диалог выбора цвета для игрока 1
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                player1Color = colorDialog.Color;
                UpdateGameUI();
            }
        }

        private void Player2ColorButton_Click(object sender, EventArgs e)
        {
            // Диалог выбора цвета для игрока 2
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                player2Color = colorDialog.Color;
                UpdateGameUI();
            }
        }

        private void BackgroundColorButton_Click(object sender, EventArgs e)
        {
            // Диалог выбора цвета фона
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                backgroundColor = colorDialog.Color;
                UpdateGameUI();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Очистка игрового поля обоих игроков
            gameGridPlayer1 = new bool[width, height];
            gameGridPlayer2 = new bool[width, height];

            // Сброс переменной очерёдности игроков
            isPlayer1Turn = true;

            // Обновление отображения
            UpdateGameUI();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Логика запуска игры
            gameTimer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            // Логика остановки игры
            gameTimer.Stop();
        }

        private void GameTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Логика обновления состояния игры для каждого поколения
            bool[,] newGameGridPlayer1 = new bool[width, height];
            bool[,] newGameGridPlayer2 = new bool[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int aliveNeighborsPlayer1 = CountAliveNeighbors(gameGridPlayer1, i, j);
                    int aliveNeighborsPlayer2 = CountAliveNeighbors(gameGridPlayer2, i, j);

                    // Правила игры для игрока 1
                    if (gameGridPlayer1[i, j])
                    {
                        if (aliveNeighborsPlayer1 < 2 || aliveNeighborsPlayer1 > 3)
                        {
                            newGameGridPlayer1[i, j] = false; // Клетка умирает
                        }
                        else
                        {
                            newGameGridPlayer1[i, j] = true; // Клетка остаётся живой
                        }
                    }
                    else
                    {
                        if (aliveNeighborsPlayer1 == 3)
                        {
                            newGameGridPlayer1[i, j] = true; // Клетка оживает
                        }
                    }

                    // Правила игры для игрока 2
                    if (gameGridPlayer2[i, j])
                    {
                        if (aliveNeighborsPlayer2 < 2 || aliveNeighborsPlayer2 > 3)
                        {
                            newGameGridPlayer2[i, j] = false; // Клетка умирает
                        }
                        else
                        {
                            newGameGridPlayer2[i, j] = true; // Клетка остаётся живой
                        }
                    }
                    else
                    {
                        if (aliveNeighborsPlayer2 == 3)
                        {
                            newGameGridPlayer2[i, j] = true; // Клетка оживает
                        }
                    }
                }
            }

            // Обновление игровых полей
            gameGridPlayer1 = newGameGridPlayer1;
            gameGridPlayer2 = newGameGridPlayer2;

            // Обновление отображения
            UpdateGameUI();
        }

        private int CountAliveNeighbors(bool[,] gameGrid, int x, int y)
        {
            int aliveNeighbors = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    int nx = x + i;
                    int ny = y + j;

                    if (nx >= 0 && nx < width && ny >= 0 && ny < height && gameGrid[nx, ny])
                    {
                        aliveNeighbors++;
                    }
                }
            }

            return aliveNeighbors;
        }


        private void OpenSocialMediaLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть ссылку: " + ex.Message);
            }
        }

        private void TelegramButton_Click(object sender, EventArgs e)
        {
            OpenSocialMediaLink("https://t.me/filmbroni");
        }


    }
}