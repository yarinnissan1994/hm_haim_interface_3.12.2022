using static ShapesForm.Circle;

namespace ShapesForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetBtn.Enabled = false;
        }

        IShape[] shapesArr = new IShape[100];

        int IShapeArrInd = 0;

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (IShapeArrInd < 100)
            {
                if (RectangleCB.Checked)
                {
                    shapesArr[IShapeArrInd] = new Rectangle();
                    IShapeArrInd++;
                    RectangleCB.Checked = false;
                }
                if (CircleCB.Checked)
                {
                    shapesArr[IShapeArrInd] = new Circle();
                    IShapeArrInd++;
                    CircleCB.Checked = false;
                }
                if (ElipseCB.Checked)
                {
                    shapesArr[IShapeArrInd] = new Elipse();
                    IShapeArrInd++;
                    ElipseCB.Checked = false;
                }
                if (TringleCB.Checked)
                {
                    shapesArr[IShapeArrInd] = new Tringle();
                    IShapeArrInd++;
                    TringleCB.Checked = false;
                }
                if (MoonCB.Checked)
                {
                    shapesArr[IShapeArrInd] = new Moon();
                    IShapeArrInd++;
                    MoonCB.Checked = false;
                }
                ResetBtn.Enabled = true;
            }
        }

        private void ResaultBtn_Click(object sender, EventArgs e)
        {
            int sumOfVertices = 0;
            for (int i = 0; i < IShapeArrInd; i++)
            {
                sumOfVertices += shapesArr[i].NumOfVertices();
            }
            ResaultLabel.Text = sumOfVertices.ToString();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < IShapeArrInd; i++)
            {
                shapesArr[i] = null;
            }
            IShapeArrInd = 0;
            ResaultLabel.Text = "0";
            ResetBtn.Enabled = false;
        }
    }
}