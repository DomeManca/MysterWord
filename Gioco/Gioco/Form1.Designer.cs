
namespace Gioco
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Inizia = new System.Windows.Forms.Button();
            this.Parola = new System.Windows.Forms.TextBox();
            this.R1L1 = new System.Windows.Forms.TextBox();
            this.R1L2 = new System.Windows.Forms.TextBox();
            this.R1L3 = new System.Windows.Forms.TextBox();
            this.R1L4 = new System.Windows.Forms.TextBox();
            this.R1L5 = new System.Windows.Forms.TextBox();
            this.R2L5 = new System.Windows.Forms.TextBox();
            this.R2L4 = new System.Windows.Forms.TextBox();
            this.R2L3 = new System.Windows.Forms.TextBox();
            this.R2L2 = new System.Windows.Forms.TextBox();
            this.R2L1 = new System.Windows.Forms.TextBox();
            this.R3L5 = new System.Windows.Forms.TextBox();
            this.R3L4 = new System.Windows.Forms.TextBox();
            this.R3L3 = new System.Windows.Forms.TextBox();
            this.R3L2 = new System.Windows.Forms.TextBox();
            this.R3L1 = new System.Windows.Forms.TextBox();
            this.R4L5 = new System.Windows.Forms.TextBox();
            this.R4L4 = new System.Windows.Forms.TextBox();
            this.R4L3 = new System.Windows.Forms.TextBox();
            this.R4L2 = new System.Windows.Forms.TextBox();
            this.R4L1 = new System.Windows.Forms.TextBox();
            this.R5L5 = new System.Windows.Forms.TextBox();
            this.R5L4 = new System.Windows.Forms.TextBox();
            this.R5L3 = new System.Windows.Forms.TextBox();
            this.R5L2 = new System.Windows.Forms.TextBox();
            this.R5L1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.VR1 = new System.Windows.Forms.Button();
            this.VR2 = new System.Windows.Forms.Button();
            this.VR3 = new System.Windows.Forms.Button();
            this.VR4 = new System.Windows.Forms.Button();
            this.VR5 = new System.Windows.Forms.Button();
            this.maschera = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.come = new System.Windows.Forms.Button();
            this.gioca = new System.Windows.Forms.Button();
            this.titolo = new System.Windows.Forms.Label();
            this.noparole = new System.Windows.Forms.Label();
            this.maschera1 = new System.Windows.Forms.PictureBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblScreen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.maschera)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maschera1)).BeginInit();
            this.SuspendLayout();
            // 
            // Inizia
            // 
            this.Inizia.Location = new System.Drawing.Point(12, 12);
            this.Inizia.Name = "Inizia";
            this.Inizia.Size = new System.Drawing.Size(100, 47);
            this.Inizia.TabIndex = 0;
            this.Inizia.Text = "Start";
            this.Inizia.UseVisualStyleBackColor = true;
            this.Inizia.Click += new System.EventHandler(this.button1_Click);
            // 
            // Parola
            // 
            this.Parola.Location = new System.Drawing.Point(137, 531);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(199, 20);
            this.Parola.TabIndex = 1;
            this.Parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R1L1
            // 
            this.R1L1.BackColor = System.Drawing.SystemColors.Window;
            this.R1L1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R1L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1L1.Location = new System.Drawing.Point(129, 93);
            this.R1L1.MaxLength = 1;
            this.R1L1.Name = "R1L1";
            this.R1L1.Size = new System.Drawing.Size(35, 35);
            this.R1L1.TabIndex = 2;
            this.R1L1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R1L2
            // 
            this.R1L2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R1L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1L2.Location = new System.Drawing.Point(170, 93);
            this.R1L2.MaxLength = 1;
            this.R1L2.Name = "R1L2";
            this.R1L2.Size = new System.Drawing.Size(35, 35);
            this.R1L2.TabIndex = 3;
            this.R1L2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R1L3
            // 
            this.R1L3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R1L3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1L3.Location = new System.Drawing.Point(211, 93);
            this.R1L3.MaxLength = 1;
            this.R1L3.Name = "R1L3";
            this.R1L3.Size = new System.Drawing.Size(35, 35);
            this.R1L3.TabIndex = 4;
            this.R1L3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R1L4
            // 
            this.R1L4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R1L4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1L4.Location = new System.Drawing.Point(252, 93);
            this.R1L4.MaxLength = 1;
            this.R1L4.Name = "R1L4";
            this.R1L4.Size = new System.Drawing.Size(35, 35);
            this.R1L4.TabIndex = 5;
            this.R1L4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R1L5
            // 
            this.R1L5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R1L5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1L5.Location = new System.Drawing.Point(293, 93);
            this.R1L5.MaxLength = 1;
            this.R1L5.Name = "R1L5";
            this.R1L5.Size = new System.Drawing.Size(35, 35);
            this.R1L5.TabIndex = 6;
            this.R1L5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R2L5
            // 
            this.R2L5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R2L5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R2L5.Location = new System.Drawing.Point(293, 134);
            this.R2L5.MaxLength = 1;
            this.R2L5.Name = "R2L5";
            this.R2L5.Size = new System.Drawing.Size(35, 35);
            this.R2L5.TabIndex = 11;
            this.R2L5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R2L4
            // 
            this.R2L4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R2L4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R2L4.Location = new System.Drawing.Point(252, 134);
            this.R2L4.MaxLength = 1;
            this.R2L4.Name = "R2L4";
            this.R2L4.Size = new System.Drawing.Size(35, 35);
            this.R2L4.TabIndex = 10;
            this.R2L4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R2L3
            // 
            this.R2L3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R2L3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R2L3.Location = new System.Drawing.Point(211, 134);
            this.R2L3.MaxLength = 1;
            this.R2L3.Name = "R2L3";
            this.R2L3.Size = new System.Drawing.Size(35, 35);
            this.R2L3.TabIndex = 9;
            this.R2L3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R2L2
            // 
            this.R2L2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R2L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R2L2.Location = new System.Drawing.Point(170, 134);
            this.R2L2.MaxLength = 1;
            this.R2L2.Name = "R2L2";
            this.R2L2.Size = new System.Drawing.Size(35, 35);
            this.R2L2.TabIndex = 8;
            this.R2L2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R2L1
            // 
            this.R2L1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R2L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R2L1.Location = new System.Drawing.Point(129, 134);
            this.R2L1.MaxLength = 1;
            this.R2L1.Name = "R2L1";
            this.R2L1.Size = new System.Drawing.Size(35, 35);
            this.R2L1.TabIndex = 7;
            this.R2L1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R3L5
            // 
            this.R3L5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R3L5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R3L5.Location = new System.Drawing.Point(293, 175);
            this.R3L5.MaxLength = 1;
            this.R3L5.Name = "R3L5";
            this.R3L5.Size = new System.Drawing.Size(35, 35);
            this.R3L5.TabIndex = 16;
            this.R3L5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R3L4
            // 
            this.R3L4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R3L4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R3L4.Location = new System.Drawing.Point(252, 175);
            this.R3L4.MaxLength = 1;
            this.R3L4.Name = "R3L4";
            this.R3L4.Size = new System.Drawing.Size(35, 35);
            this.R3L4.TabIndex = 15;
            this.R3L4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R3L3
            // 
            this.R3L3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R3L3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R3L3.Location = new System.Drawing.Point(211, 175);
            this.R3L3.MaxLength = 1;
            this.R3L3.Name = "R3L3";
            this.R3L3.Size = new System.Drawing.Size(35, 35);
            this.R3L3.TabIndex = 14;
            this.R3L3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R3L2
            // 
            this.R3L2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R3L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R3L2.Location = new System.Drawing.Point(170, 175);
            this.R3L2.MaxLength = 1;
            this.R3L2.Name = "R3L2";
            this.R3L2.Size = new System.Drawing.Size(35, 35);
            this.R3L2.TabIndex = 13;
            this.R3L2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R3L1
            // 
            this.R3L1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R3L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R3L1.Location = new System.Drawing.Point(129, 175);
            this.R3L1.MaxLength = 1;
            this.R3L1.Name = "R3L1";
            this.R3L1.Size = new System.Drawing.Size(35, 35);
            this.R3L1.TabIndex = 12;
            this.R3L1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R4L5
            // 
            this.R4L5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R4L5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R4L5.Location = new System.Drawing.Point(293, 216);
            this.R4L5.MaxLength = 1;
            this.R4L5.Name = "R4L5";
            this.R4L5.Size = new System.Drawing.Size(35, 35);
            this.R4L5.TabIndex = 21;
            this.R4L5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R4L4
            // 
            this.R4L4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R4L4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R4L4.Location = new System.Drawing.Point(252, 216);
            this.R4L4.MaxLength = 1;
            this.R4L4.Name = "R4L4";
            this.R4L4.Size = new System.Drawing.Size(35, 35);
            this.R4L4.TabIndex = 20;
            this.R4L4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R4L3
            // 
            this.R4L3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R4L3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R4L3.Location = new System.Drawing.Point(211, 216);
            this.R4L3.MaxLength = 1;
            this.R4L3.Name = "R4L3";
            this.R4L3.Size = new System.Drawing.Size(35, 35);
            this.R4L3.TabIndex = 19;
            this.R4L3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R4L2
            // 
            this.R4L2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R4L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R4L2.Location = new System.Drawing.Point(170, 216);
            this.R4L2.MaxLength = 1;
            this.R4L2.Name = "R4L2";
            this.R4L2.Size = new System.Drawing.Size(35, 35);
            this.R4L2.TabIndex = 18;
            this.R4L2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R4L1
            // 
            this.R4L1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R4L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R4L1.Location = new System.Drawing.Point(129, 216);
            this.R4L1.MaxLength = 1;
            this.R4L1.Name = "R4L1";
            this.R4L1.Size = new System.Drawing.Size(35, 35);
            this.R4L1.TabIndex = 17;
            this.R4L1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R5L5
            // 
            this.R5L5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R5L5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R5L5.Location = new System.Drawing.Point(293, 257);
            this.R5L5.MaxLength = 1;
            this.R5L5.Name = "R5L5";
            this.R5L5.Size = new System.Drawing.Size(35, 35);
            this.R5L5.TabIndex = 26;
            this.R5L5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R5L4
            // 
            this.R5L4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R5L4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R5L4.Location = new System.Drawing.Point(252, 257);
            this.R5L4.MaxLength = 1;
            this.R5L4.Name = "R5L4";
            this.R5L4.Size = new System.Drawing.Size(35, 35);
            this.R5L4.TabIndex = 25;
            this.R5L4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R5L3
            // 
            this.R5L3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R5L3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R5L3.Location = new System.Drawing.Point(211, 257);
            this.R5L3.MaxLength = 1;
            this.R5L3.Name = "R5L3";
            this.R5L3.Size = new System.Drawing.Size(35, 35);
            this.R5L3.TabIndex = 24;
            this.R5L3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R5L2
            // 
            this.R5L2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R5L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R5L2.Location = new System.Drawing.Point(170, 257);
            this.R5L2.MaxLength = 1;
            this.R5L2.Name = "R5L2";
            this.R5L2.Size = new System.Drawing.Size(35, 35);
            this.R5L2.TabIndex = 23;
            this.R5L2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R5L1
            // 
            this.R5L1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.R5L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R5L1.Location = new System.Drawing.Point(129, 257);
            this.R5L1.MaxLength = 1;
            this.R5L1.Name = "R5L1";
            this.R5L1.Size = new System.Drawing.Size(35, 35);
            this.R5L1.TabIndex = 22;
            this.R5L1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "S";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VR1
            // 
            this.VR1.Location = new System.Drawing.Point(396, 311);
            this.VR1.Name = "VR1";
            this.VR1.Size = new System.Drawing.Size(35, 35);
            this.VR1.TabIndex = 29;
            this.VR1.Text = "✔️";
            this.VR1.UseVisualStyleBackColor = true;
            this.VR1.Click += new System.EventHandler(this.VR1_Click);
            // 
            // VR2
            // 
            this.VR2.Location = new System.Drawing.Point(396, 311);
            this.VR2.Name = "VR2";
            this.VR2.Size = new System.Drawing.Size(35, 35);
            this.VR2.TabIndex = 30;
            this.VR2.Text = "✔️";
            this.VR2.UseVisualStyleBackColor = true;
            this.VR2.Click += new System.EventHandler(this.VR2_Click);
            // 
            // VR3
            // 
            this.VR3.Location = new System.Drawing.Point(396, 311);
            this.VR3.Name = "VR3";
            this.VR3.Size = new System.Drawing.Size(35, 35);
            this.VR3.TabIndex = 31;
            this.VR3.Text = "✔️";
            this.VR3.UseVisualStyleBackColor = true;
            // 
            // VR4
            // 
            this.VR4.Location = new System.Drawing.Point(396, 311);
            this.VR4.Name = "VR4";
            this.VR4.Size = new System.Drawing.Size(35, 35);
            this.VR4.TabIndex = 32;
            this.VR4.Text = "✔️";
            this.VR4.UseVisualStyleBackColor = true;
            // 
            // VR5
            // 
            this.VR5.Location = new System.Drawing.Point(396, 311);
            this.VR5.Name = "VR5";
            this.VR5.Size = new System.Drawing.Size(35, 35);
            this.VR5.TabIndex = 33;
            this.VR5.Text = "✔️";
            this.VR5.UseVisualStyleBackColor = true;
            // 
            // maschera
            // 
            this.maschera.Location = new System.Drawing.Point(137, 531);
            this.maschera.Name = "maschera";
            this.maschera.Size = new System.Drawing.Size(199, 20);
            this.maschera.TabIndex = 27;
            this.maschera.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.come);
            this.panel1.Controls.Add(this.gioca);
            this.panel1.Controls.Add(this.titolo);
            this.panel1.Location = new System.Drawing.Point(-9, -33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 600);
            this.panel1.TabIndex = 36;
            // 
            // come
            // 
            this.come.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.come.Location = new System.Drawing.Point(125, 475);
            this.come.Name = "come";
            this.come.Size = new System.Drawing.Size(200, 30);
            this.come.TabIndex = 2;
            this.come.Text = "COME SI GIOCA";
            this.come.UseVisualStyleBackColor = true;
            // 
            // gioca
            // 
            this.gioca.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioca.Location = new System.Drawing.Point(125, 389);
            this.gioca.Name = "gioca";
            this.gioca.Size = new System.Drawing.Size(200, 80);
            this.gioca.TabIndex = 1;
            this.gioca.Text = "GIOCA";
            this.gioca.UseVisualStyleBackColor = true;
            this.gioca.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // titolo
            // 
            this.titolo.AutoSize = true;
            this.titolo.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titolo.Location = new System.Drawing.Point(95, 55);
            this.titolo.Name = "titolo";
            this.titolo.Size = new System.Drawing.Size(259, 39);
            this.titolo.TabIndex = 0;
            this.titolo.Text = "MYSTERYWORD";
            // 
            // noparole
            // 
            this.noparole.AutoSize = true;
            this.noparole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noparole.Location = new System.Drawing.Point(114, 416);
            this.noparole.Name = "noparole";
            this.noparole.Size = new System.Drawing.Size(248, 20);
            this.noparole.TabIndex = 36;
            this.noparole.Text = "Parola non presente nel dizionario";
            // 
            // maschera1
            // 
            this.maschera1.Location = new System.Drawing.Point(110, 416);
            this.maschera1.Name = "maschera1";
            this.maschera1.Size = new System.Drawing.Size(252, 20);
            this.maschera1.TabIndex = 37;
            this.maschera1.TabStop = false;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMinutes.Location = new System.Drawing.Point(176, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(42, 46);
            this.lblMinutes.TabIndex = 39;
            this.lblMinutes.Text = "0";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblScreen
            // 
            this.lblScreen.AutoSize = true;
            this.lblScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblScreen.Location = new System.Drawing.Point(223, 0);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(64, 46);
            this.lblScreen.TabIndex = 38;
            this.lblScreen.Text = "00";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 46);
            this.label1.TabIndex = 40;
            this.label1.Text = ":";
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblScreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maschera1);
            this.Controls.Add(this.VR5);
            this.Controls.Add(this.VR4);
            this.Controls.Add(this.noparole);
            this.Controls.Add(this.VR3);
            this.Controls.Add(this.VR2);
            this.Controls.Add(this.VR1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maschera);
            this.Controls.Add(this.R5L5);
            this.Controls.Add(this.R5L4);
            this.Controls.Add(this.R5L3);
            this.Controls.Add(this.R5L2);
            this.Controls.Add(this.R5L1);
            this.Controls.Add(this.R4L5);
            this.Controls.Add(this.R4L4);
            this.Controls.Add(this.R4L3);
            this.Controls.Add(this.R4L2);
            this.Controls.Add(this.R4L1);
            this.Controls.Add(this.R3L5);
            this.Controls.Add(this.R3L4);
            this.Controls.Add(this.R3L3);
            this.Controls.Add(this.R3L2);
            this.Controls.Add(this.R3L1);
            this.Controls.Add(this.R2L5);
            this.Controls.Add(this.R2L4);
            this.Controls.Add(this.R2L3);
            this.Controls.Add(this.R2L2);
            this.Controls.Add(this.R2L1);
            this.Controls.Add(this.R1L5);
            this.Controls.Add(this.R1L4);
            this.Controls.Add(this.R1L3);
            this.Controls.Add(this.R1L2);
            this.Controls.Add(this.R1L1);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.Inizia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Svela";
            ((System.ComponentModel.ISupportInitialize)(this.maschera)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maschera1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inizia;
        private System.Windows.Forms.TextBox Parola;
        private System.Windows.Forms.TextBox R1L1;
        private System.Windows.Forms.TextBox R1L2;
        private System.Windows.Forms.TextBox R1L3;
        private System.Windows.Forms.TextBox R1L4;
        private System.Windows.Forms.TextBox R1L5;
        private System.Windows.Forms.TextBox R2L5;
        private System.Windows.Forms.TextBox R2L4;
        private System.Windows.Forms.TextBox R2L3;
        private System.Windows.Forms.TextBox R2L2;
        private System.Windows.Forms.TextBox R2L1;
        private System.Windows.Forms.TextBox R3L5;
        private System.Windows.Forms.TextBox R3L4;
        private System.Windows.Forms.TextBox R3L3;
        private System.Windows.Forms.TextBox R3L2;
        private System.Windows.Forms.TextBox R3L1;
        private System.Windows.Forms.TextBox R4L5;
        private System.Windows.Forms.TextBox R4L4;
        private System.Windows.Forms.TextBox R4L3;
        private System.Windows.Forms.TextBox R4L2;
        private System.Windows.Forms.TextBox R4L1;
        private System.Windows.Forms.TextBox R5L5;
        private System.Windows.Forms.TextBox R5L4;
        private System.Windows.Forms.TextBox R5L3;
        private System.Windows.Forms.TextBox R5L2;
        private System.Windows.Forms.TextBox R5L1;
        private System.Windows.Forms.PictureBox maschera;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button VR1;
        private System.Windows.Forms.Button VR2;
        private System.Windows.Forms.Button VR3;
        private System.Windows.Forms.Button VR4;
        private System.Windows.Forms.Button VR5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button come;
        private System.Windows.Forms.Button gioca;
        private System.Windows.Forms.Label titolo;
        private System.Windows.Forms.Label noparole;
        private System.Windows.Forms.PictureBox maschera1;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer countdownTimer;
    }
}

