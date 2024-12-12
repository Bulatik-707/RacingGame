by Aryslan IT 

см скриншоты

Код
===================




using System;
using System.Windows.Forms;

namespace RacingGame
{
	public partial class RacingGame : Form
	{
		public RacingGame()
		{
			InitializeComponent();
			// Параметры при запуске.

			// При запуске программы скрыть
			// Надпись и Кнопку Рестари
			label_GameOwer.Visible = false;
			button_Restart.Visible = false;
			// Получить события клавиатуры (нажатие. для перемещения)
			KeyPreview = true; 

		}

		// Кол-во собраных монет
		private uint countCoins = 0;
		private void timer1_Tick( object sender, EventArgs e )
		{
			// Анимация двидения по трассе
			int speed = 10;
			// Смещение с верхней границы
			// Джижение врагов
			pB_Fon.Top += speed;
			pB_Fon2.Top += speed;
			// движение монетки - Coin
			pB_Coin.Top += speed;

			// Если отступ сверху 650, вернуть фоновую картинку назад
			if ( pB_Fon.Top >= 560 )
			{
				pB_Fon.Top = 0;
				pB_Fon2.Top = -560;
			}

			// Появление врагов (pB_Enemy*)

			// Анимация двидения по трассе
			int Enemy_Speed = 7;
			// Смещение с верхней границы
			pB_Enemy1.Top += Enemy_Speed;
			pB_Enemy2.Top += Enemy_Speed;
			// Если отступ сверху 600, вернуть картинку назад
			if ( pB_Fon.Top >= 560 )
			{
				pB_Fon.Top = 0;
				pB_Fon2.Top = -560;
			}

			// Чтобы враги появлялись постоянно.
			// Места для появления в px (для красоты) чтобы не появлялась посредине дороги
			int[] new_positions_Enemy1 = { 100, 250}; 
			// Если прошел низ карты, вернуть назад (вверх)
			if ( pB_Enemy1.Top >= 650 )
			{
				pB_Enemy1.Top = -200;

				// Появление врагов в случ. месте. от левого края - к правому (до центра).
				Random random = new Random();
				// pB_Enemy1.Left = random.Next( 90, 250 );
				// выбрать случ. знвчение из new_positions_Enemy1
				pB_Enemy1.Left = new_positions_Enemy1[ random.Next( 0, new_positions_Enemy1.Length )];				
			}

			// Места для появления в px
			int[] new_positions_Enemy2 = { 420, 580 };
			if ( pB_Enemy2.Top >= 650 )
			{
				pB_Enemy2.Top = -160;

				// Появление врагов в случ. месте. от центра левого края - к правому.
				Random random = new Random();
				//pB_Enemy2.Left = random.Next( 410, 700 );
				// выбрать случ. знвчение из new_positions_Enemy1
				pB_Enemy2.Left = new_positions_Enemy2[random.Next( 0, new_positions_Enemy2.Length )];
			}

			// Монетка. появление сверху и в случ. месте
			if ( pB_Coin.Top > 600 )
			{
				pB_Coin.Top = -50;

				Random random = new Random();
				pB_Coin.Left = random.Next( 90, 700 );
			}

			// События столкновения
			// (Bounds - размер элемента)
			// (IntersectsWith - проверяет пересекаются прямоуг или нет. с чем либо)
			// Если столкнулись с 1м врагом ИЛИ || 2м
			if ( pB_Player.Bounds.IntersectsWith( pB_Enemy1.Bounds ) || pB_Player.Bounds.IntersectsWith( pB_Enemy2.Bounds ) )
			{
				// Отключаю таймер 1 (остановка движения)
				timer1.Enabled = false;

				// Делаем видимым надпись и кнопку
				label_GameOwer.Visible = true;
				button_Restart.Visible = true;
			}

			// Сбор монет
			if( pB_Player.Bounds.IntersectsWith(pB_Coin.Bounds) )
			{
				// + счет
				countCoins++;
				label_Count.Text = "Count: " + countCoins.ToString();

				// перемещаем монету. (тут можно ЛУЧЩЕ написать функцию которая копирует этот код)
				pB_Coin.Top = -50;

				Random random = new Random();
				pB_Coin.Left = random.Next( 90, 710 );
			}
			 
		}

		private void RacingGame_KeyPress( object sender, KeyPressEventArgs e )
		{
			// СОбытия при нажатии (1 РАЗ - KeyPress) по клавиатуре.

		}

		private void RacingGame_KeyDown( object sender, KeyEventArgs e )
		{
			// СОбытия при нажатии  по клавиатуре (ПОСТОЯННО - KeyDown).
			// Вдижение нашей машинки
			// Скорость движения обьекта
			int speed = 10;

			// Код клавы которая сейчас нажата. Если ГГ нажимает СТРЕЛОЧКУ ВЛЕВО
			/* чтобы не выходить за границу карты && pB_Player.Left > 90  */
			if ( e.KeyCode == Keys.Left /* || e.KeyCode == Keys.D */ && pB_Player.Left > 90 )
			{
				// Перемещаю машину хулакай
				pB_Player.Left -= speed;
			}
			// чтобы не выходить за границу карты pB_Player.Right < 720
			else if ( e.KeyCode == Keys.Right && pB_Player.Right < 715 )
			{
				// Перемещаю машину уньяк
				pB_Player.Left += speed;
			}
			else if ( e.KeyCode == Keys.Up )
			{
				// Перемещаю машину Алга
				pB_Player.Top -= speed;
			}
			else if ( e.KeyCode == Keys.Down )
			{
				// Перемещаю машину артка
				pB_Player.Top += speed;
			}
		}

		private void button_Restart_Click( object sender, EventArgs e )
		{
			// Restart игры
			// Обращаемся к каждому объекту игры.
			// Новая стартовая позиция врагов
			pB_Enemy1.Top = -400;
			pB_Enemy2.Top = -300;
			// Скрыть текст и кнопку
			label_GameOwer.Visible = false;
			button_Restart.Visible = false;
			// обнулить счет. Новая стартовая позиция Coin
			countCoins = 0;
			label_Count.Text = "Count: 0";

			pB_Coin.Top = -500;
			// запустить таймер
			timer1.Enabled = true;
		}
	}
}
