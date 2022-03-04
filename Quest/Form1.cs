using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quest
{
    public partial class Form1 : Form
    {
        public int GameStage = 0;// стадия игры
        public string PlayerName = ""; 
        bool NeedClick = true;// флаг на необходимость клика для продолжения
        Сharacter player_character = new Сharacter(); // создание персанажа

        public string CurentSelectionValue ; //значение которое выбрал игрок
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        { NeedClick = true; 
            CurentSelectionValue = (textBox1.Text);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;// автоскролл 
            listBox1.SelectedIndex = -1; // автоскролл
            listBox1.Items.Add("");
            if(GameStage == 0) // стадия игрок представляется
            {
                listBox1.Items.Add("Добро пожаловать в королосевство Гномов");
                listBox1.Items.Add("Назови себя");
                if (textBox1.Text == "")
                {
                    GameStage = 0;
                }
                else
                {
                    Name = textBox1.Text;                   // запоминаем и назначаем имя игрока
                    player_character.SetPlayerName(Name);
                    GameStage++;
                }

            }
            if(GameStage == 1) // выбирайем класс героя, пока он не наберет один из 3х вариантов
            {
                listBox1.Items.Add("Мы рады видеть тебя " +Name);
                listBox1.Items.Add("Выбери свой класс" );
                listBox1.Items.Add("1 - волшебник, 2 - лучник, 3 - воин");
                if (CurentSelectionValue == "1"|| CurentSelectionValue == "2" || CurentSelectionValue == "3")
                {
                    player_character.PickClass_player(CurentSelectionValue);
                    GameStage++;
                    
                }
               


            }
            if (GameStage == 2) // показываем какие характеристики у данного класса
            {
                listBox1.Items.Add("Ты прирожденный "+ Convert.ToString( player_character.GetClassName())); //записываем в строки значения соответсвующих параетров из класса character
                listBox1.Items.Add("У тебя " + Convert.ToString(player_character.GetHp())+ " Очков здоровья ");
                listBox1.Items.Add("Интелект " + Convert.ToString(player_character.GetIntelligence()));
                listBox1.Items.Add("Сила " + Convert.ToString(player_character.GetStrength()));
                listBox1.Items.Add("Ловкость " + Convert.ToString(player_character.GetAgility()));
                GameStage++;
                NeedClick = false;
            }
            if (GameStage == 3&&NeedClick)
            {
                listBox1.Items.Add("Ты оказался в пещере полной гномов");
                GameStage++;
                NeedClick = false;
            }
            if (GameStage == 4 && NeedClick)
            {
                listBox1.Items.Add("Перед тобой 2 путя");
                GameStage++;
                NeedClick = false;
            }
            if (GameStage == 5 && NeedClick)
            {
                listBox1.Items.Add("Путь налево темный и от туда веет холодом");
                GameStage++;
                NeedClick = false;
            }
            if (GameStage == 6 && NeedClick)
            {
                listBox1.Items.Add("Путь направо светлый и от туда доносится смех маленького мальчика");
                GameStage++;
                NeedClick = false;
            }
            if (GameStage == 7 && NeedClick)
            {
                listBox1.Items.Add("Какой путь выберет герой?");
                GameStage++;
                NeedClick = false;
            }
            if (GameStage == 8 && NeedClick)
            {
                listBox1.Items.Add("Вы слишком долго думал, на вас упал троль - вы погибли");
                GameStage++;
                NeedClick = false;
            }
            CurentSelectionValue = "0";
            textBox1.Text = "";


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
