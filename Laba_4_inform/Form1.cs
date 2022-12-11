namespace Laba_4_inform
{
    public partial class Form1 : Form
    {

        public static List<Cat> Cats = new List<Cat>();//список пассажирских поездов
        public static List<Bird> Birds = new List<Bird>();//список грузовых поездов
        public Form1()
        {
            InitializeComponent();
        }

        private void update()//Обновляет данные в dataGridView1 и dataGridView2
        {
            dataGridView1.Rows.Clear();
            int n = Cats.Count;
            if (n > 0)
                dataGridView1.Rows.Add(n);
            for (int i = 0; i < n; ++i)
            {
                dataGridView1.Rows[i].Cells["Weight"].Value = Cats[i].GetWeight();
                dataGridView1.Rows[i].Cells["Name"].Value = Cats[i].GetName();
                dataGridView1.Rows[i].Cells["Age"].Value = Cats[i].GetAge();
                dataGridView1.Rows[i].Cells["Color"].Value = Cats[i].GetColor();
                dataGridView1.Rows[i].Cells["Breed"].Value = Cats[i].GetBreed();
            }
            dataGridView2.Rows.Clear();
            n = Birds.Count;
            if (n > 0)
                dataGridView2.Rows.Add(n);
            for (int i = 0; i < n; ++i)
            {
                dataGridView2.Rows[i].Cells["Weight"].Value = Birds[i].GetWeight();
                dataGridView2.Rows[i].Cells["Form"].Value = Birds[i].GetForm();
                dataGridView2.Rows[i].Cells["Wingspan"].Value = Birds[i].GetWingSpan();
                dataGridView2.Rows[i].Cells["Color"].Value = Birds[i].GetColor();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Animal
    {
        private string _color;
        private int _weight;

        public string GetColor()
        {
            return _color;
        }

        public int GetWeight()
        {
            return _weight;
        }

        public void SetColor(string value)
        {
            _color = value;
        }

        public void SetWeight(int value)
        {
            _weight = value;
        }

        public Animal(string color,int weight)
        {
            _color = color;
            _weight = weight;
        }

    }

    public class Cat : Animal
    {
        private string _name;
        private int _age;
        private string _breed;

        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }

        public string GetBreed()
        {
            return _breed;
        }

        public void SetName(string value)
        {
            _name = value;
        }

        public void SetAge(int value)
        {
            _age = value;
        }

        public void SetBreed(string value)
        {
            _breed = value;
        }

        public Cat(int weight,string name,int age,string color,string breed) : base(color,weight)
        {
            _name = name;
            _age = age;
            _breed = breed;
        }

    }

    public class Bird : Animal
    {
        private string _form;
        private int _wingspan;

        public string GetForm()
        {
            return _form;
        }

        public int GetWingSpan()
        {
            return _wingspan;
        }

        public void SetForm(string value)
        {
            _form = value;
        }

        public void SetWingSpan(int value)
        {
            _wingspan = value;
        }

        public Bird(int weight,string form,int wingspan,string color) : base(color,weight)
        {
            _form = form;
            _wingspan = wingspan;
        }
    }
}