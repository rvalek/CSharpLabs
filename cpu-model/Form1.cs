using cpu_model.core;
using System;
using System.Windows.Forms;

namespace cpu_model {
    public partial class Form1 : Form {
        private Model m;
        private double intensityThreshold;
        private int burstMin;
        private int burstMax;
        private int priorityMin;
        private int priorityMax;


        public Form1() {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e) {
            try {
                readConfigs();
            } catch (InvalidConfigException ex) {
                return;
            }
            m = new Model(intensityThreshold, burstMin, burstMax, priorityMin, priorityMax);

            disableConfigs();
            nextButton.Enabled = true;
        }

        private void Next_Click(object sender, EventArgs e) {
            m.NextTime();
            updateStateViews();
        }

        private void Reset_Click(object sender, EventArgs e) {
            nextButton.Enabled = false;
            enableConfigs();

            m = null;
            resetStateViews();
        }

        private void updateStateViews() {
            clockTimeLabel.Text = m.ClockGen.CurrentTime.ToString();
            //
        }

        private void resetStateViews() {
            clockTimeLabel.Text = "0";
            //
        }


        private void updateTimeLabel() {
        }

        private void readConfigs() {
            intensityThreshold = (double) thresholdUpnDown.Value;
            burstMin = (int) burstMinUpDown.Value;
            burstMax = (int) burstMaxUpDown.Value;
            priorityMin = (int) priorityMinUpDown.Value;
            priorityMax = (int) priorityMaxUpDown.Value;

            if (burstMin > burstMax || priorityMin > priorityMax) {
                throw new InvalidConfigException();
            }
        }

        private void enableConfigs() {
            thresholdUpnDown.Enabled = true;
            burstMinUpDown.Enabled = true;
            burstMaxUpDown.Enabled = true;
            priorityMinUpDown.Enabled = true;
            priorityMaxUpDown.Enabled = true;
        }

        private void disableConfigs() {
            thresholdUpnDown.Enabled = false;
            burstMinUpDown.Enabled = false;
            burstMaxUpDown.Enabled = false;
            priorityMinUpDown.Enabled = false;
            priorityMaxUpDown.Enabled = false;
        }

    }

    public class InvalidConfigException : Exception {
        public InvalidConfigException() : base() { }
        public InvalidConfigException(string msg) : base(msg) { }
    }
}
