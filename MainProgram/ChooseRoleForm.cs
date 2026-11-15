using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;



namespace online_library_for_educ_inst
{
    public partial class FmChooseRoleForm : Form
    {
        public static FmChooseRoleForm FRM_Choose_role_Form_Instanse;
        private Bitmap _bg;
        public FmChooseRoleForm()
        {
            InitializeComponent();

            FRM_Choose_role_Form_Instanse = this;
        }

        private void FmChooseRoleForm_Load(object sender, EventArgs e)
        {
            ChooseRoleFormClass.GetActivatedTransparentComponent(this);

            CustomClass.GetRoundedShapeForm(this);

            ChooseRoleFormClass.GetAnimatedDrawText(this);

            ChooseRoleFormClass.GetAnimatedPanel(this);

            CustomClass.PlaySoundEffect(FormUsrAlert.enmNamesOfSoundProject.SoundFormOpen.ToString());

            ChooseRoleFormClass.CallWelcomeMessage(this);
        }

        private void FmChooseRoleForm_Activated(object sender, EventArgs e)
        {
            CustomClass.isLoadAdminRole = false;

            ChooseRoleFormClass.GetActivateWelcomeForm(this);

        }

        private void TimerToAnimaitonPict_Tick(object sender, EventArgs e)
        {
            ChooseRoleFormClass.GetAnimationChangePict(this);
        }

        private void TimerToAnimationForm_Tick(object sender, EventArgs e)
        {
            CustomClass.CallAnimationAppearanceForm(this, TimerToAnimationForm);
        }

        private void ExitApp_MouseLeave(object sender, EventArgs e)
        {
            PictExitApp.Image = Properties.Resources.IconDefaultExit;
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            ChooseRoleFormClass.ExitFromApplication(this);
        }

        private void ExitApp_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(FormUsrAlert.enmNamesOfSoundProject.SoundCursor.ToString());
            PictExitApp.Image = Properties.Resources.IconCursorExit;
            ToolTipHelpUser.SetToolTip(PictExitApp, "Выйти из приложения");
        }

        private void PictLicense_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(FormUsrAlert.enmNamesOfSoundProject.SoundCursor.ToString());
            PictLicense.Image = Properties.Resources.LicenseAgreementClicked;
            ToolTipHelpUser.SetToolTip(PictLicense, "Лицензионное соглашение с конечным пользователем");
        }

        private void PictLicense_MouseLeave(object sender, EventArgs e)
        {
            PictLicense.Image = Properties.Resources.LicenseAgreementCursor;
        }

        private void LblUserText_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(FormUsrAlert.enmNamesOfSoundProject.SoundCursor.ToString());
            LblUserText.ForeColor = Color.FromArgb(0, 174, 219);
            ToolTipHelpUser.SetToolTip(LblUserText, "Войти в приложение как пользователь");
        }

        private void LblUserText_MouseLeave(object sender, EventArgs e)
        {
            LblUserText.ForeColor = Color.WhiteSmoke;
        }

        private void LblAdminText_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(FormUsrAlert.enmNamesOfSoundProject.SoundCursor.ToString());
            LblAdminText.ForeColor = Color.FromArgb(0, 174, 219);
            ToolTipHelpUser.SetToolTip(LblAdminText, "Войти в приложение как администратор");
        }

        private void LblAdminText_MouseLeave(object sender, EventArgs e)
        {
            LblAdminText.ForeColor = Color.WhiteSmoke;
        }
        private void LblAdminText_Click(object sender, EventArgs e)
        {

            LblAdminText.ForeColor = Color.Aqua;

            CustomClass.Alert("В процессе разработки!", FormUsrAlert.enmType.Warning);
        }

        private void LblUserText_Click(object sender, EventArgs e)
        {
            ChooseRoleFormClass.CallWelcomeForm(this);
        }

        private void PictLicense_Click(object sender, EventArgs e)
        {
            ChooseRoleFormClass.CallLicenseAgreement(this);
        }

        private void FmChooseRoleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            GC.Collect();
        }

        private void FmChooseRoleForm_Resize(object sender, EventArgs e)
        {
            BuildBackground();
            Invalidate();
        }

        private void FmChooseRoleForm_Paint(object sender, PaintEventArgs e)
        {
            if (_bg != null) e.Graphics.DrawImageUnscaled(_bg, 0, 0);
            else base.OnPaintBackground(e);
        }

        private void BuildBackground()
        {
            int w = ClientSize.Width, h = ClientSize.Height;
            if (w < 1 || h < 1) return;

            _bg?.Dispose();
            _bg = new Bitmap(w, h);
            var g = Graphics.FromImage(_bg);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new Rectangle(0, 0, w, h);

            // 1. Основной градиент: тёмно-синий -> насыщенный голубой
            using (var br = new LinearGradientBrush(rect,
                Color.FromArgb(8, 28, 78), Color.FromArgb(22, 130, 210), 35f))
                g.FillRectangle(br, rect);

            // 2. Мягкое свечение в правом верхнем углу
            DrawGlow(g, new PointF(w * 0.85f, h * 0.15f), w * 0.45f, Color.FromArgb(90, 80, 200, 255));
            // и слева снизу
            DrawGlow(g, new PointF(w * 0.10f, h * 0.90f), w * 0.40f, Color.FromArgb(70, 120, 90, 255));

            // 3. Полупрозрачные волны
            DrawWave(g, w, h, 0.62f, 0.08f, Color.FromArgb(40, 255, 255, 255));
            DrawWave(g, w, h, 0.75f, 0.06f, Color.FromArgb(30, 0, 40, 120));
            DrawWave(g, w, h, 0.88f, 0.05f, Color.FromArgb(35, 0, 174, 221));
        }

        private static void DrawGlow(Graphics g, PointF c, float r, Color color)
        {
            var path = new GraphicsPath();
            path.AddEllipse(c.X - r, c.Y - r, r * 2, r * 2);
            var pg = new PathGradientBrush(path)
            {
                CenterColor = color,
                SurroundColors = new[] { Color.FromArgb(0, color) }
            };
            g.FillPath(pg, path);
        }

        private static void DrawWave(Graphics g, int w, int h, float yRel, float ampRel, Color color)
        {
            float y = h * yRel, a = h * ampRel;
            var path = new GraphicsPath();
            path.AddBezier(0, y, w * 0.25f, y - a * 2, w * 0.45f, y + a * 2, w * 0.60f, y);
            path.AddBezier(w * 0.60f, y, w * 0.78f, y - a * 1.5f, w * 0.90f, y + a, w, y - a * 0.5f);
            path.AddLine(w, y - a * 0.5f, w, h);
            path.AddLine(w, h, 0, h);
            path.CloseFigure();
            var br = new SolidBrush(color);
            g.FillPath(br, path);
        }
    }   
    }



