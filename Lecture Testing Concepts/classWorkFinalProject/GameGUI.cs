namespace classWorkFinalProject
{
    public partial class GameGUI : Form
    {
        //picture boxes
        PictureBox[] heroPBs = new PictureBox[3];
        PictureBox[] enemyPBs = new PictureBox[3];

        //events
        public event EventHandler AttackButtonClicked;

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
        public void UpdateEventHandler(object? sender, UpdateEventArgs e)
        {
            //this is where the battleLog will be appended with actions
        }

        #region events that need to be moved

        //player controls
        private void OnAttackBtn_Click(object sender, EventArgs e)
        {
            battleLog.AppendText("You attacked!" + "\r\n");
        }

        private void OnDefendBtn_Click(object sender, EventArgs e)
        {
            battleLog.AppendText("You're defending!" + "\r\n");
        }

        private void OnSpecialBtn_Click(object sender, EventArgs e)
        {
            battleLog.AppendText("You used your special move!" + "\r\n");
        }

        //target selection
        private void OnEnemyPB1_Click(object sender, EventArgs e)
        {
            battleLog.AppendText("You selected enemy one!" + "\r\n");
        }

        #endregion

    }
}