namespace classWorkFinalProject
{
    public partial class GameGUI : Form
    {
        PictureBox[] heroPBs = new PictureBox[3];
        PictureBox[] enemyPBs = new PictureBox[3];
        public GameGUI()
        {
            InitializeComponent();
            heroPBs[0] = heroPB1;
            heroPBs[1] = heroPB2;
            heroPBs[2] = heroPB3;
            enemyPBs[0] = enemyPB1;
            enemyPBs[1] = enemyPB2;
            enemyPBs[2] = enemyPB3;
        }

        /// <summary>
        /// Method updates heroes in the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HeroesUpdateHandler(object? sender, HeroesUpdateEventArgs e)
        {
            for (int i = 0; i < e.Heroes.Count; i++) 
            {
                heroPBs[i].Image = e.Heroes[i].MySprite;
            }
        }

        /// <summary>
        /// Method updates enemies in the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EnemiesUpdateHandler(object? sender, EnemiesUpdateEventArgs e)
        {
            for (int i = 0; i < e.EnemyEncounter.Count; i++)
            {
                enemyPBs[i].Image = e.EnemyEncounter[i].MySprite;
            }
        }

        //create update handler here

        #region Events that will likely need to move
        //player controls
        private void OnAttackBtn_Click(object sender, EventArgs e)
        {
            battleLog.Text += "You attacked!" + "\r\n";
        }

        private void OnDefendBtn_Click(object sender, EventArgs e)
        {
            battleLog.Text += "You're defending!" + "\r\n";
        }

        private void OnSpecialBtn_Click(object sender, EventArgs e)
        {
            battleLog.Text += "You used your special move!" + "\r\n";
        }

        //target selection
        private void OnEnemyPB1_Click(object sender, EventArgs e)
        {
            battleLog.Text += "You selected enemy one!" + "\r\n";
        }

        #endregion

    }
}