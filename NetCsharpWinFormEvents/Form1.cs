namespace NetCsharpWinFormEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (PointToClient(MousePosition).X > ClientRectangle.X + 10 && PointToClient(MousePosition).X < ClientRectangle.Width - 10 && PointToClient(MousePosition).Y > ClientRectangle.Y + 10 && PointToClient(MousePosition).Y < ClientRectangle.Height - 10)
                {
                    MessageBox.Show("Курсор внутри", "", MessageBoxButtons.OK);
                }
                else if (PointToClient(MousePosition).X == 10 || PointToClient(MousePosition).X == ClientRectangle.Width - 10 || PointToClient(MousePosition).Y == 10 || PointToClient(MousePosition).Y == ClientRectangle.Height - 10)
                {
                    MessageBox.Show("Курсор на границе воображаемого прямоугольника", "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Курсор снаружи", "", MessageBoxButtons.OK);
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                this.Text = $"X: {ClientRectangle.Width} - Y: {ClientRectangle.Height}";
            }

        }
        //для отображения 2й таски нужно закомментировать эту ->
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X: {PointToClient(MousePosition).X} - Y: {PointToClient(MousePosition).Y}";
        }
    }
}
