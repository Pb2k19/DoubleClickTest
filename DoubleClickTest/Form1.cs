using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.Versioning;

namespace DoubleClickTest;

[SupportedOSPlatform("windows")]
public partial class MainForm : Form
{
    private const int MinNonErrorElapsedTimeMs = 100;

    private readonly Stopwatch stopwatch = new();
    private int clickCount = 0, errorCount = 0;
    private long fastestClickMs = 9999;

    public MainForm()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        OutputTextBox.ScrollBars = ScrollBars.Both;
        SetDefaultValues();
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

    void Test(MouseButtons mouse)
    {
        stopwatch.Stop();
        long elapsedTimeMs = stopwatch.ElapsedMilliseconds;
        stopwatch.Restart();

        clickCount++;
        ElapsedMsLabel.Text = elapsedTimeMs.ToString();
        ClickCountLabel.Text = clickCount.ToString();

        if (elapsedTimeMs < fastestClickMs)
        {
            fastestClickMs = elapsedTimeMs;
            FastestClickLabel.Text = fastestClickMs.ToString();
        }

        if (elapsedTimeMs < MinNonErrorElapsedTimeMs)
        {
            errorCount++;
            ErrorClickCountLabel.Text = errorCount.ToString();

            TestButton.BackColor = Color.Red;
            CheckStateLabel.Text = "ERROR";

            OutputTextBox.AppendText($"{Environment.NewLine}Error: Click number {clickCount} - interval: {elapsedTimeMs}ms - button: {mouse}{Environment.NewLine}");
        }
    }

    private void SetDefaultValues()
    {
        fastestClickMs = 9999;
        clickCount = 0;
        errorCount = 0;

        CheckStateLabel.Text = "OK";
        ClickCountLabel.Text = "0";
        ErrorClickCountLabel.Text = "0";
        FastestClickLabel.Text = "0";
        ElapsedMsLabel.Text = "0";

        TestButton.BackColor = SystemColors.Control;
        OutputTextBox.Clear();
        stopwatch.Reset();
        stopwatch.Start();
    }
}