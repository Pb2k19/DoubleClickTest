using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace DoubleClickTest;

public partial class MainForm : Form
{
    private readonly Stopwatch stopwatch = new();
    private int count = 0, errorCount = 0;
    private long fc = 1000;

    public MainForm()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        textBox1.ScrollBars = ScrollBars.Both;
        SetDefaultValues();
    }

    void Test(MouseButtons mouse)
    {
        stopwatch.Stop();
        ElapsedMsLabel.Text = stopwatch.ElapsedMilliseconds.ToString();
        count++;
        ClickCountLabel.Text = count.ToString();
        if(fc > stopwatch.ElapsedMilliseconds && stopwatch.ElapsedMilliseconds > 80)
        {
            fc = stopwatch.ElapsedMilliseconds;
            label2.Text = fc.ToString();
        }
        if (stopwatch.ElapsedMilliseconds < 100)
        {
            button1.BackColor = Color.Red;
            CheckStateLabel.Text = "ERROR";
            errorCount++;
            ErrorClickCountLabel.Text = errorCount.ToString();
            textBox1.AppendText("\n Fast click number " + count.ToString() + " interval: " + stopwatch.ElapsedMilliseconds.ToString()+"ms  button: "+mouse.ToString());
            textBox1.AppendText(Environment.NewLine);
        }
        stopwatch.Reset();
        stopwatch.Start();
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
        Test(e.Button);
    }

    private void Button1_MouseDown(object sender, MouseEventArgs e)
    {
        Test(e.Button);
    }

    private void Reset_Click(object sender, EventArgs e)
    {
        SetDefaultValues();
    }

    private void SetDefaultValues()
    {
        fc = 1000;
        count = 0;
        errorCount = 0;
        CheckStateLabel.Text = "OK";
        ClickCountLabel.Text = "0";
        ErrorClickCountLabel.Text = count.ToString();
        textBox1.Clear();
        button1.BackColor = SystemColors.Control;
        stopwatch.Reset();
        stopwatch.Start();
    }
}
