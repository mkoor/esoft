namespace esoft2
{
    partial class FormRealEstate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRealEstate));
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.TotalArea_Apartaments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rooms_Apartaments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Floor_Apartaments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRealEstateSet_House = new System.Windows.Forms.ListView();
            this.Address_City_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_Street_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_House_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_Number_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coordinate_latitude_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coordinate_longitude_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalArea_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalFloors_House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRealEstateSet_Land = new System.Windows.Forms.ListView();
            this.Address_City_Land = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_Street_Land = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_House_Land = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_Number_Land = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coordinate_latitude_Land = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coordinate_longitude_Land = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalArea_Lend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.Coordinate_longitude_Apartaments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Coordinate_latitude_Apartaments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRealEstateSet_Apartment = new System.Windows.Forms.ListView();
            this.Address_City_Apartaments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_Street_Apartaments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_House_Apartaments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_Number_Apartaments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelType = new System.Windows.Forms.Label();
            this.labelTotalFloors = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.labelTotalArea = new System.Windows.Forms.Label();
            this.labelCoordinate_longitude = new System.Windows.Forms.Label();
            this.labelCoordinate_latitude = new System.Windows.Forms.Label();
            this.labelAddress_Number = new System.Windows.Forms.Label();
            this.labelAddress_House = new System.Windows.Forms.Label();
            this.labelAddress_Street = new System.Windows.Forms.Label();
            this.labelAddress_City = new System.Windows.Forms.Label();
            this.textBoxTotalFloors = new System.Windows.Forms.TextBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.textBoxRooms = new System.Windows.Forms.TextBox();
            this.textBoxTotalArea = new System.Windows.Forms.TextBox();
            this.textBoxCoordinate_longitude = new System.Windows.Forms.TextBox();
            this.textBoxCoordinate_latitude = new System.Windows.Forms.TextBox();
            this.textBoxAddress_Number = new System.Windows.Forms.TextBox();
            this.textBoxAddress_House = new System.Windows.Forms.TextBox();
            this.textBoxAddress_Street = new System.Windows.Forms.TextBox();
            this.textBoxAddress_City = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(9, 265);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(162, 21);
            this.comboBoxType.TabIndex = 56;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // TotalArea_Apartaments
            // 
            this.TotalArea_Apartaments.Text = "Площадь";
            this.TotalArea_Apartaments.Width = 72;
            // 
            // Rooms_Apartaments
            // 
            this.Rooms_Apartaments.Text = "Количество комнат";
            this.Rooms_Apartaments.Width = 136;
            // 
            // Floor_Apartaments
            // 
            this.Floor_Apartaments.Text = "Этаж";
            // 
            // listViewRealEstateSet_House
            // 
            this.listViewRealEstateSet_House.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address_City_House,
            this.Address_Street_House,
            this.Address_House_House,
            this.Address_Number_House,
            this.Coordinate_latitude_House,
            this.Coordinate_longitude_House,
            this.TotalArea_House,
            this.TotalFloors_House});
            this.listViewRealEstateSet_House.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewRealEstateSet_House.FullRowSelect = true;
            this.listViewRealEstateSet_House.GridLines = true;
            this.listViewRealEstateSet_House.HideSelection = false;
            this.listViewRealEstateSet_House.Location = new System.Drawing.Point(201, 26);
            this.listViewRealEstateSet_House.MultiSelect = false;
            this.listViewRealEstateSet_House.Name = "listViewRealEstateSet_House";
            this.listViewRealEstateSet_House.Size = new System.Drawing.Size(759, 367);
            this.listViewRealEstateSet_House.TabIndex = 51;
            this.listViewRealEstateSet_House.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_House.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_House.Visible = false;
            this.listViewRealEstateSet_House.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_House_SelectedIndexChanged);
            // 
            // Address_City_House
            // 
            this.Address_City_House.Text = "Город";
            this.Address_City_House.Width = 79;
            // 
            // Address_Street_House
            // 
            this.Address_Street_House.Text = "Улица";
            this.Address_Street_House.Width = 90;
            // 
            // Address_House_House
            // 
            this.Address_House_House.Text = "Номер дома";
            this.Address_House_House.Width = 92;
            // 
            // Address_Number_House
            // 
            this.Address_Number_House.Text = "Номер квартиры";
            this.Address_Number_House.Width = 103;
            // 
            // Coordinate_latitude_House
            // 
            this.Coordinate_latitude_House.Text = "Широта";
            this.Coordinate_latitude_House.Width = 80;
            // 
            // Coordinate_longitude_House
            // 
            this.Coordinate_longitude_House.Text = "Долгота";
            this.Coordinate_longitude_House.Width = 84;
            // 
            // TotalArea_House
            // 
            this.TotalArea_House.Text = "Площадь";
            this.TotalArea_House.Width = 69;
            // 
            // TotalFloors_House
            // 
            this.TotalFloors_House.Text = "Количество этажей";
            this.TotalFloors_House.Width = 115;
            // 
            // listViewRealEstateSet_Land
            // 
            this.listViewRealEstateSet_Land.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address_City_Land,
            this.Address_Street_Land,
            this.Address_House_Land,
            this.Address_Number_Land,
            this.Coordinate_latitude_Land,
            this.Coordinate_longitude_Land,
            this.TotalArea_Lend});
            this.listViewRealEstateSet_Land.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewRealEstateSet_Land.FullRowSelect = true;
            this.listViewRealEstateSet_Land.GridLines = true;
            this.listViewRealEstateSet_Land.HideSelection = false;
            this.listViewRealEstateSet_Land.Location = new System.Drawing.Point(201, 26);
            this.listViewRealEstateSet_Land.MultiSelect = false;
            this.listViewRealEstateSet_Land.Name = "listViewRealEstateSet_Land";
            this.listViewRealEstateSet_Land.Size = new System.Drawing.Size(783, 367);
            this.listViewRealEstateSet_Land.TabIndex = 52;
            this.listViewRealEstateSet_Land.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Land.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_Land.Visible = false;
            // 
            // Address_City_Land
            // 
            this.Address_City_Land.Text = "Город";
            this.Address_City_Land.Width = 119;
            // 
            // Address_Street_Land
            // 
            this.Address_Street_Land.Text = "Улица";
            this.Address_Street_Land.Width = 113;
            // 
            // Address_House_Land
            // 
            this.Address_House_Land.Text = "Номер дома";
            this.Address_House_Land.Width = 97;
            // 
            // Address_Number_Land
            // 
            this.Address_Number_Land.Text = "Номер квартиры";
            this.Address_Number_Land.Width = 127;
            // 
            // Coordinate_latitude_Land
            // 
            this.Coordinate_latitude_Land.Text = "Широта";
            this.Coordinate_latitude_Land.Width = 104;
            // 
            // Coordinate_longitude_Land
            // 
            this.Coordinate_longitude_Land.Text = "Долгота";
            this.Coordinate_longitude_Land.Width = 92;
            // 
            // TotalArea_Lend
            // 
            this.TotalArea_Lend.Text = "Площадь";
            this.TotalArea_Lend.Width = 122;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDel.Location = new System.Drawing.Point(750, 419);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(181, 46);
            this.buttonDel.TabIndex = 55;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(508, 419);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(181, 46);
            this.buttonEdit.TabIndex = 54;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(268, 419);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(181, 46);
            this.buttonAdd.TabIndex = 53;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Coordinate_longitude_Apartaments
            // 
            this.Coordinate_longitude_Apartaments.Text = "Долгота";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 412);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // Coordinate_latitude_Apartaments
            // 
            this.Coordinate_latitude_Apartaments.Text = "Широта";
            // 
            // listViewRealEstateSet_Apartment
            // 
            this.listViewRealEstateSet_Apartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address_City_Apartaments,
            this.Address_Street_Apartaments,
            this.Address_House_Apartaments,
            this.Address_Number_Apartaments,
            this.Coordinate_latitude_Apartaments,
            this.Coordinate_longitude_Apartaments,
            this.TotalArea_Apartaments,
            this.Rooms_Apartaments,
            this.Floor_Apartaments});
            this.listViewRealEstateSet_Apartment.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewRealEstateSet_Apartment.FullRowSelect = true;
            this.listViewRealEstateSet_Apartment.GridLines = true;
            this.listViewRealEstateSet_Apartment.HideSelection = false;
            this.listViewRealEstateSet_Apartment.Location = new System.Drawing.Point(201, 26);
            this.listViewRealEstateSet_Apartment.MultiSelect = false;
            this.listViewRealEstateSet_Apartment.Name = "listViewRealEstateSet_Apartment";
            this.listViewRealEstateSet_Apartment.Size = new System.Drawing.Size(783, 367);
            this.listViewRealEstateSet_Apartment.TabIndex = 50;
            this.listViewRealEstateSet_Apartment.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Apartment.View = System.Windows.Forms.View.Details;
            // 
            // Address_City_Apartaments
            // 
            this.Address_City_Apartaments.Text = "Город";
            this.Address_City_Apartaments.Width = 79;
            // 
            // Address_Street_Apartaments
            // 
            this.Address_Street_Apartaments.Text = "Улица";
            this.Address_Street_Apartaments.Width = 89;
            // 
            // Address_House_Apartaments
            // 
            this.Address_House_Apartaments.Text = "Номер дома";
            this.Address_House_Apartaments.Width = 89;
            // 
            // Address_Number_Apartaments
            // 
            this.Address_Number_Apartaments.Text = "Номер квартиры";
            this.Address_Number_Apartaments.Width = 116;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(6, 249);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(26, 13);
            this.labelType.TabIndex = 49;
            this.labelType.Text = "Тип";
            // 
            // labelTotalFloors
            // 
            this.labelTotalFloors.AutoSize = true;
            this.labelTotalFloors.Location = new System.Drawing.Point(6, 329);
            this.labelTotalFloors.Name = "labelTotalFloors";
            this.labelTotalFloors.Size = new System.Drawing.Size(106, 13);
            this.labelTotalFloors.TabIndex = 48;
            this.labelTotalFloors.Text = "Количество этажей";
            this.labelTotalFloors.Visible = false;
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Location = new System.Drawing.Point(6, 369);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(33, 13);
            this.labelFloor.TabIndex = 47;
            this.labelFloor.Text = "Этаж";
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRooms.Location = new System.Drawing.Point(7, 329);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(109, 13);
            this.labelRooms.TabIndex = 46;
            this.labelRooms.Text = "Количество комнат";
            // 
            // labelTotalArea
            // 
            this.labelTotalArea.AutoSize = true;
            this.labelTotalArea.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalArea.Location = new System.Drawing.Point(6, 289);
            this.labelTotalArea.Name = "labelTotalArea";
            this.labelTotalArea.Size = new System.Drawing.Size(56, 13);
            this.labelTotalArea.TabIndex = 45;
            this.labelTotalArea.Text = "Площадь";
            // 
            // labelCoordinate_longitude
            // 
            this.labelCoordinate_longitude.AutoSize = true;
            this.labelCoordinate_longitude.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoordinate_longitude.Location = new System.Drawing.Point(6, 209);
            this.labelCoordinate_longitude.Name = "labelCoordinate_longitude";
            this.labelCoordinate_longitude.Size = new System.Drawing.Size(50, 13);
            this.labelCoordinate_longitude.TabIndex = 44;
            this.labelCoordinate_longitude.Text = "Долгота";
            // 
            // labelCoordinate_latitude
            // 
            this.labelCoordinate_latitude.AutoSize = true;
            this.labelCoordinate_latitude.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoordinate_latitude.Location = new System.Drawing.Point(6, 169);
            this.labelCoordinate_latitude.Name = "labelCoordinate_latitude";
            this.labelCoordinate_latitude.Size = new System.Drawing.Size(48, 13);
            this.labelCoordinate_latitude.TabIndex = 43;
            this.labelCoordinate_latitude.Text = "Широта";
            // 
            // labelAddress_Number
            // 
            this.labelAddress_Number.AutoSize = true;
            this.labelAddress_Number.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress_Number.Location = new System.Drawing.Point(9, 129);
            this.labelAddress_Number.Name = "labelAddress_Number";
            this.labelAddress_Number.Size = new System.Drawing.Size(95, 13);
            this.labelAddress_Number.TabIndex = 42;
            this.labelAddress_Number.Text = "Номер квартиры";
            // 
            // labelAddress_House
            // 
            this.labelAddress_House.AutoSize = true;
            this.labelAddress_House.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress_House.Location = new System.Drawing.Point(9, 89);
            this.labelAddress_House.Name = "labelAddress_House";
            this.labelAddress_House.Size = new System.Drawing.Size(71, 13);
            this.labelAddress_House.TabIndex = 41;
            this.labelAddress_House.Text = "Номер дома";
            // 
            // labelAddress_Street
            // 
            this.labelAddress_Street.AutoSize = true;
            this.labelAddress_Street.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress_Street.Location = new System.Drawing.Point(9, 49);
            this.labelAddress_Street.Name = "labelAddress_Street";
            this.labelAddress_Street.Size = new System.Drawing.Size(39, 13);
            this.labelAddress_Street.TabIndex = 40;
            this.labelAddress_Street.Text = "Улица";
            // 
            // labelAddress_City
            // 
            this.labelAddress_City.AutoSize = true;
            this.labelAddress_City.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress_City.Location = new System.Drawing.Point(9, 10);
            this.labelAddress_City.Name = "labelAddress_City";
            this.labelAddress_City.Size = new System.Drawing.Size(37, 13);
            this.labelAddress_City.TabIndex = 39;
            this.labelAddress_City.Text = "Город";
            // 
            // textBoxTotalFloors
            // 
            this.textBoxTotalFloors.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotalFloors.Location = new System.Drawing.Point(9, 345);
            this.textBoxTotalFloors.Name = "textBoxTotalFloors";
            this.textBoxTotalFloors.Size = new System.Drawing.Size(162, 21);
            this.textBoxTotalFloors.TabIndex = 38;
            this.textBoxTotalFloors.Visible = false;
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFloor.Location = new System.Drawing.Point(9, 385);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(162, 21);
            this.textBoxFloor.TabIndex = 37;
            // 
            // textBoxRooms
            // 
            this.textBoxRooms.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRooms.Location = new System.Drawing.Point(9, 345);
            this.textBoxRooms.Name = "textBoxRooms";
            this.textBoxRooms.Size = new System.Drawing.Size(162, 21);
            this.textBoxRooms.TabIndex = 36;
            // 
            // textBoxTotalArea
            // 
            this.textBoxTotalArea.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotalArea.Location = new System.Drawing.Point(9, 305);
            this.textBoxTotalArea.Name = "textBoxTotalArea";
            this.textBoxTotalArea.Size = new System.Drawing.Size(162, 21);
            this.textBoxTotalArea.TabIndex = 35;
            // 
            // textBoxCoordinate_longitude
            // 
            this.textBoxCoordinate_longitude.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoordinate_longitude.Location = new System.Drawing.Point(9, 225);
            this.textBoxCoordinate_longitude.Name = "textBoxCoordinate_longitude";
            this.textBoxCoordinate_longitude.Size = new System.Drawing.Size(162, 21);
            this.textBoxCoordinate_longitude.TabIndex = 34;
            this.textBoxCoordinate_longitude.TextChanged += new System.EventHandler(this.textBoxCoordinate_longitude_TextChanged);
            this.textBoxCoordinate_longitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoordinate_longitude_TextChanged);
            // 
            // textBoxCoordinate_latitude
            // 
            this.textBoxCoordinate_latitude.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoordinate_latitude.Location = new System.Drawing.Point(9, 185);
            this.textBoxCoordinate_latitude.Name = "textBoxCoordinate_latitude";
            this.textBoxCoordinate_latitude.Size = new System.Drawing.Size(162, 21);
            this.textBoxCoordinate_latitude.TabIndex = 33;
            this.textBoxCoordinate_latitude.TextChanged += new System.EventHandler(this.textBoxCoordinate_latitude_TextChanged);
            this.textBoxCoordinate_latitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoordinate_latitude_TextChanged);
            // 
            // textBoxAddress_Number
            // 
            this.textBoxAddress_Number.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress_Number.Location = new System.Drawing.Point(9, 145);
            this.textBoxAddress_Number.Name = "textBoxAddress_Number";
            this.textBoxAddress_Number.Size = new System.Drawing.Size(162, 21);
            this.textBoxAddress_Number.TabIndex = 32;
            // 
            // textBoxAddress_House
            // 
            this.textBoxAddress_House.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress_House.Location = new System.Drawing.Point(9, 105);
            this.textBoxAddress_House.Name = "textBoxAddress_House";
            this.textBoxAddress_House.Size = new System.Drawing.Size(162, 21);
            this.textBoxAddress_House.TabIndex = 31;
            // 
            // textBoxAddress_Street
            // 
            this.textBoxAddress_Street.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress_Street.Location = new System.Drawing.Point(9, 65);
            this.textBoxAddress_Street.Name = "textBoxAddress_Street";
            this.textBoxAddress_Street.Size = new System.Drawing.Size(162, 21);
            this.textBoxAddress_Street.TabIndex = 30;
            // 
            // textBoxAddress_City
            // 
            this.textBoxAddress_City.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress_City.Location = new System.Drawing.Point(9, 26);
            this.textBoxAddress_City.Name = "textBoxAddress_City";
            this.textBoxAddress_City.Size = new System.Drawing.Size(162, 21);
            this.textBoxAddress_City.TabIndex = 29;
            // 
            // FormRealEstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 491);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.listViewRealEstateSet_House);
            this.Controls.Add(this.listViewRealEstateSet_Land);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewRealEstateSet_Apartment);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTotalFloors);
            this.Controls.Add(this.labelFloor);
            this.Controls.Add(this.labelRooms);
            this.Controls.Add(this.labelTotalArea);
            this.Controls.Add(this.labelCoordinate_longitude);
            this.Controls.Add(this.labelCoordinate_latitude);
            this.Controls.Add(this.labelAddress_Number);
            this.Controls.Add(this.labelAddress_House);
            this.Controls.Add(this.labelAddress_Street);
            this.Controls.Add(this.labelAddress_City);
            this.Controls.Add(this.textBoxTotalFloors);
            this.Controls.Add(this.textBoxFloor);
            this.Controls.Add(this.textBoxRooms);
            this.Controls.Add(this.textBoxTotalArea);
            this.Controls.Add(this.textBoxCoordinate_longitude);
            this.Controls.Add(this.textBoxCoordinate_latitude);
            this.Controls.Add(this.textBoxAddress_Number);
            this.Controls.Add(this.textBoxAddress_House);
            this.Controls.Add(this.textBoxAddress_Street);
            this.Controls.Add(this.textBoxAddress_City);
            this.Name = "FormRealEstate";
            this.Text = "Объекты недвижимости";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ColumnHeader TotalArea_Apartaments;
        private System.Windows.Forms.ColumnHeader Rooms_Apartaments;
        private System.Windows.Forms.ColumnHeader Floor_Apartaments;
        private System.Windows.Forms.ListView listViewRealEstateSet_House;
        private System.Windows.Forms.ColumnHeader Address_City_House;
        private System.Windows.Forms.ColumnHeader Address_Street_House;
        private System.Windows.Forms.ColumnHeader Address_House_House;
        private System.Windows.Forms.ColumnHeader Address_Number_House;
        private System.Windows.Forms.ColumnHeader Coordinate_latitude_House;
        private System.Windows.Forms.ColumnHeader Coordinate_longitude_House;
        private System.Windows.Forms.ColumnHeader TotalArea_House;
        private System.Windows.Forms.ColumnHeader TotalFloors_House;
        private System.Windows.Forms.ListView listViewRealEstateSet_Land;
        private System.Windows.Forms.ColumnHeader Address_City_Land;
        private System.Windows.Forms.ColumnHeader Address_Street_Land;
        private System.Windows.Forms.ColumnHeader Address_House_Land;
        private System.Windows.Forms.ColumnHeader Address_Number_Land;
        private System.Windows.Forms.ColumnHeader Coordinate_latitude_Land;
        private System.Windows.Forms.ColumnHeader Coordinate_longitude_Land;
        private System.Windows.Forms.ColumnHeader TotalArea_Lend;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader Coordinate_longitude_Apartaments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader Coordinate_latitude_Apartaments;
        private System.Windows.Forms.ListView listViewRealEstateSet_Apartment;
        private System.Windows.Forms.ColumnHeader Address_City_Apartaments;
        private System.Windows.Forms.ColumnHeader Address_Street_Apartaments;
        private System.Windows.Forms.ColumnHeader Address_House_Apartaments;
        private System.Windows.Forms.ColumnHeader Address_Number_Apartaments;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelTotalFloors;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.Label labelTotalArea;
        private System.Windows.Forms.Label labelCoordinate_longitude;
        private System.Windows.Forms.Label labelCoordinate_latitude;
        private System.Windows.Forms.Label labelAddress_Number;
        private System.Windows.Forms.Label labelAddress_House;
        private System.Windows.Forms.Label labelAddress_Street;
        private System.Windows.Forms.Label labelAddress_City;
        private System.Windows.Forms.TextBox textBoxTotalFloors;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.TextBox textBoxRooms;
        private System.Windows.Forms.TextBox textBoxTotalArea;
        private System.Windows.Forms.TextBox textBoxCoordinate_longitude;
        private System.Windows.Forms.TextBox textBoxCoordinate_latitude;
        private System.Windows.Forms.TextBox textBoxAddress_Number;
        private System.Windows.Forms.TextBox textBoxAddress_House;
        private System.Windows.Forms.TextBox textBoxAddress_Street;
        private System.Windows.Forms.TextBox textBoxAddress_City;
    }
}