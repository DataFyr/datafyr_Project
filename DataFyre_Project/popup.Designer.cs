﻿namespace datascience_project
{
    partial class popup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popup));
            //Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            //Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            //Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.yesBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtMessage = new System.Windows.Forms.Label();
            this.NoBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnOk = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(378, 26);
            this.panel5.TabIndex = 42;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(356, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // yesBtn
            // 
            this.yesBtn.AllowAnimations = true;
            this.yesBtn.AllowMouseEffects = true;
            this.yesBtn.AllowToggling = false;
            this.yesBtn.AnimationSpeed = 200;
            this.yesBtn.AutoGenerateColors = false;
            this.yesBtn.AutoRoundBorders = false;
            this.yesBtn.AutoSizeLeftIcon = true;
            this.yesBtn.AutoSizeRightIcon = true;
            this.yesBtn.BackColor = System.Drawing.Color.Transparent;
            this.yesBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.yesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yesBtn.BackgroundImage")));
            this.yesBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.yesBtn.ButtonText = "Yes";
            this.yesBtn.ButtonTextMarginLeft = 0;
            this.yesBtn.ColorContrastOnClick = 45;
            this.yesBtn.ColorContrastOnHover = 45;
            this.yesBtn.Cursor = System.Windows.Forms.Cursors.Default;
            //borderEdges1.BottomLeft = true;
            //borderEdges1.BottomRight = true;
            //borderEdges1.TopLeft = true;
            //borderEdges1.TopRight = true;
            //this.yesBtn.CustomizableEdges = borderEdges1;
            this.yesBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.yesBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.yesBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.yesBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.yesBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.yesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.yesBtn.ForeColor = System.Drawing.Color.White;
            this.yesBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yesBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.yesBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.yesBtn.IconMarginLeft = 11;
            this.yesBtn.IconPadding = 10;
            this.yesBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yesBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.yesBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.yesBtn.IconSize = 25;
            this.yesBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.yesBtn.IdleBorderRadius = 1;
            this.yesBtn.IdleBorderThickness = 1;
            this.yesBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.yesBtn.IdleIconLeftImage = null;
            this.yesBtn.IdleIconRightImage = null;
            this.yesBtn.IndicateFocus = false;
            this.yesBtn.Location = new System.Drawing.Point(94, 122);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.yesBtn.OnDisabledState.BorderRadius = 1;
            this.yesBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.yesBtn.OnDisabledState.BorderThickness = 1;
            this.yesBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.yesBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.yesBtn.OnDisabledState.IconLeftImage = null;
            this.yesBtn.OnDisabledState.IconRightImage = null;
            this.yesBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.yesBtn.onHoverState.BorderRadius = 1;
            this.yesBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.yesBtn.onHoverState.BorderThickness = 1;
            this.yesBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.yesBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.yesBtn.onHoverState.IconLeftImage = null;
            this.yesBtn.onHoverState.IconRightImage = null;
            this.yesBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.yesBtn.OnIdleState.BorderRadius = 1;
            this.yesBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.yesBtn.OnIdleState.BorderThickness = 1;
            this.yesBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.yesBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.yesBtn.OnIdleState.IconLeftImage = null;
            this.yesBtn.OnIdleState.IconRightImage = null;
            this.yesBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.yesBtn.OnPressedState.BorderRadius = 1;
            this.yesBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.yesBtn.OnPressedState.BorderThickness = 1;
            this.yesBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.yesBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.yesBtn.OnPressedState.IconLeftImage = null;
            this.yesBtn.OnPressedState.IconRightImage = null;
            this.yesBtn.Size = new System.Drawing.Size(90, 30);
            this.yesBtn.TabIndex = 43;
            this.yesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yesBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.yesBtn.TextMarginLeft = 0;
            this.yesBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.yesBtn.UseDefaultRadiusAndThickness = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(27, 58);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(0, 25);
            this.txtMessage.TabIndex = 44;
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NoBtn
            // 
            this.NoBtn.AllowAnimations = true;
            this.NoBtn.AllowMouseEffects = true;
            this.NoBtn.AllowToggling = false;
            this.NoBtn.AnimationSpeed = 200;
            this.NoBtn.AutoGenerateColors = false;
            this.NoBtn.AutoRoundBorders = false;
            this.NoBtn.AutoSizeLeftIcon = true;
            this.NoBtn.AutoSizeRightIcon = true;
            this.NoBtn.BackColor = System.Drawing.Color.Transparent;
            this.NoBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(108)))));
            this.NoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NoBtn.BackgroundImage")));
            this.NoBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.NoBtn.ButtonText = "No";
            this.NoBtn.ButtonTextMarginLeft = 0;
            this.NoBtn.ColorContrastOnClick = 45;
            this.NoBtn.ColorContrastOnHover = 45;
            this.NoBtn.Cursor = System.Windows.Forms.Cursors.Default;
            //borderEdges2.BottomLeft = true;
            //borderEdges2.BottomRight = true;
            //borderEdges2.TopLeft = true;
            //borderEdges2.TopRight = true;
            //this.NoBtn.CustomizableEdges = borderEdges2;
            this.NoBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.NoBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.NoBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.NoBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.NoBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.NoBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NoBtn.ForeColor = System.Drawing.Color.White;
            this.NoBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NoBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.NoBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.NoBtn.IconMarginLeft = 11;
            this.NoBtn.IconPadding = 10;
            this.NoBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NoBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.NoBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.NoBtn.IconSize = 25;
            this.NoBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(108)))));
            this.NoBtn.IdleBorderRadius = 1;
            this.NoBtn.IdleBorderThickness = 1;
            this.NoBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(108)))));
            this.NoBtn.IdleIconLeftImage = null;
            this.NoBtn.IdleIconRightImage = null;
            this.NoBtn.IndicateFocus = false;
            this.NoBtn.Location = new System.Drawing.Point(190, 122);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.NoBtn.OnDisabledState.BorderRadius = 1;
            this.NoBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.NoBtn.OnDisabledState.BorderThickness = 1;
            this.NoBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.NoBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.NoBtn.OnDisabledState.IconLeftImage = null;
            this.NoBtn.OnDisabledState.IconRightImage = null;
            this.NoBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(108)))));
            this.NoBtn.onHoverState.BorderRadius = 1;
            this.NoBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.NoBtn.onHoverState.BorderThickness = 1;
            this.NoBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(108)))));
            this.NoBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.NoBtn.onHoverState.IconLeftImage = null;
            this.NoBtn.onHoverState.IconRightImage = null;
            this.NoBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(108)))));
            this.NoBtn.OnIdleState.BorderRadius = 1;
            this.NoBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.NoBtn.OnIdleState.BorderThickness = 1;
            this.NoBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(108)))));
            this.NoBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.NoBtn.OnIdleState.IconLeftImage = null;
            this.NoBtn.OnIdleState.IconRightImage = null;
            this.NoBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(108)))));
            this.NoBtn.OnPressedState.BorderRadius = 1;
            this.NoBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.NoBtn.OnPressedState.BorderThickness = 1;
            this.NoBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(108)))));
            this.NoBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.NoBtn.OnPressedState.IconLeftImage = null;
            this.NoBtn.OnPressedState.IconRightImage = null;
            this.NoBtn.Size = new System.Drawing.Size(90, 30);
            this.NoBtn.TabIndex = 45;
            this.NoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.NoBtn.TextMarginLeft = 0;
            this.NoBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.NoBtn.UseDefaultRadiusAndThickness = true;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // btnOk
            // 
            this.btnOk.AllowAnimations = true;
            this.btnOk.AllowMouseEffects = true;
            this.btnOk.AllowToggling = false;
            this.btnOk.AnimationSpeed = 200;
            this.btnOk.AutoGenerateColors = false;
            this.btnOk.AutoRoundBorders = false;
            this.btnOk.AutoSizeLeftIcon = true;
            this.btnOk.AutoSizeRightIcon = true;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
            this.btnOk.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOk.ButtonText = "OK";
            this.btnOk.ButtonTextMarginLeft = 0;
            this.btnOk.ColorContrastOnClick = 45;
            this.btnOk.ColorContrastOnHover = 45;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Default;
            //borderEdges3.BottomLeft = true;
            //borderEdges3.BottomRight = true;
            //borderEdges3.TopLeft = true;
            //borderEdges3.TopRight = true;
            //this.btnOk.CustomizableEdges = borderEdges3;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOk.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOk.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOk.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOk.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnOk.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnOk.IconMarginLeft = 11;
            this.btnOk.IconPadding = 10;
            this.btnOk.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnOk.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnOk.IconSize = 25;
            this.btnOk.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.btnOk.IdleBorderRadius = 1;
            this.btnOk.IdleBorderThickness = 1;
            this.btnOk.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.btnOk.IdleIconLeftImage = null;
            this.btnOk.IdleIconRightImage = null;
            this.btnOk.IndicateFocus = false;
            this.btnOk.Location = new System.Drawing.Point(148, 122);
            this.btnOk.Name = "btnOk";
            this.btnOk.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOk.OnDisabledState.BorderRadius = 1;
            this.btnOk.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOk.OnDisabledState.BorderThickness = 1;
            this.btnOk.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOk.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOk.OnDisabledState.IconLeftImage = null;
            this.btnOk.OnDisabledState.IconRightImage = null;
            this.btnOk.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.btnOk.onHoverState.BorderRadius = 1;
            this.btnOk.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOk.onHoverState.BorderThickness = 1;
            this.btnOk.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.btnOk.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnOk.onHoverState.IconLeftImage = null;
            this.btnOk.onHoverState.IconRightImage = null;
            this.btnOk.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.btnOk.OnIdleState.BorderRadius = 1;
            this.btnOk.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOk.OnIdleState.BorderThickness = 1;
            this.btnOk.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.btnOk.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnOk.OnIdleState.IconLeftImage = null;
            this.btnOk.OnIdleState.IconRightImage = null;
            this.btnOk.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.btnOk.OnPressedState.BorderRadius = 1;
            this.btnOk.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOk.OnPressedState.BorderThickness = 1;
            this.btnOk.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(110)))));
            this.btnOk.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnOk.OnPressedState.IconLeftImage = null;
            this.btnOk.OnPressedState.IconRightImage = null;
            this.btnOk.Size = new System.Drawing.Size(90, 30);
            this.btnOk.TabIndex = 46;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOk.TextMarginLeft = 0;
            this.btnOk.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnOk.UseDefaultRadiusAndThickness = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 164);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popup";
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton yesBtn;
        private System.Windows.Forms.Label txtMessage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton NoBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOk;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}