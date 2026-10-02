using System.Windows.Forms;
namespace UI
{
    public partial class RoomManagementForm : Form
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

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.llblNav = new System.Windows.Forms.LinkLabel();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.colRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActions = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblCount = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader — the blue bar on top of the form
            // 
            this.panelHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 45);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle — "Room Management" text inside the blue bar
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(15, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Room Management";
            // 
            // panelInfo — gray bar showing the logged-in user
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelInfo.Controls.Add(this.llblNav);
            this.panelInfo.Controls.Add(this.lblUserInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 45);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(900, 29);
            this.panelInfo.TabIndex = 1;
            // 
            // llblNav — Main Menu / Logout links on the right side
            // 
            this.llblNav.AutoSize = true;
            this.llblNav.LinkColor = System.Drawing.Color.Black;
            this.llblNav.Location = new System.Drawing.Point(728, 6);
            this.llblNav.Name = "llblNav";
            this.llblNav.Size = new System.Drawing.Size(147, 16);
            this.llblNav.TabIndex = 1;
            this.llblNav.TabStop = true;
            this.llblNav.Text = "[ Main Menu ]  [ Logout ]";
            this.llblNav.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNav_LinkClicked);
            // 
            // lblUserInfo — shows the logged-in user's name and role
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Location = new System.Drawing.Point(5, 6);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(217, 16);
            this.lblUserInfo.TabIndex = 0;
            this.lblUserInfo.Text = "Logged in as: [Name] | Role: [Role]";
            // 
            // btnAdd — "+ Add Room" button (Admin only)
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(740, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+ Add Room";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStatusFilter — "Filter by Status:" label
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusFilter.Location = new System.Drawing.Point(20, 97);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.Size = new System.Drawing.Size(126, 18);
            this.lblStatusFilter.TabIndex = 5;
            this.lblStatusFilter.Text = "Filter by Status:";
            // 
            // cmbStatusFilter — dropdown for filtering by status
            // 
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Items.AddRange(new object[] {
            "All",
            "Available",
            "Occupied",
            "Maintenance"});
            this.cmbStatusFilter.Location = new System.Drawing.Point(152, 91);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(160, 24);
            this.cmbStatusFilter.TabIndex = 6;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // dgvRooms — the main table showing all rooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRooms.AutoGenerateColumns = false;
            this.dgvRooms.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomNumber,
            this.colType,
            this.colRate,
            this.colStatus,
            this.colActions});
            this.dgvRooms.Location = new System.Drawing.Point(20, 130);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowHeadersWidth = 51;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(850, 350);
            this.dgvRooms.TabIndex = 3;
            this.dgvRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellContentClick);
            // 
            // colRoomNumber — the room's number (e.g., 201)
            // 
            this.colRoomNumber.DataPropertyName = "RoomNumber";
            this.colRoomNumber.HeaderText = "Room #";
            this.colRoomNumber.MinimumWidth = 6;
            this.colRoomNumber.Name = "colRoomNumber";
            this.colRoomNumber.Width = 120;
            // 
            // colType — Ward / Private / Semi-Private / ICU
            // 
            this.colType.DataPropertyName = "RoomType";
            this.colType.HeaderText = "Type";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.Width = 180;
            // 
            // colRate — how much the room costs per day
            // 
            this.colRate.DataPropertyName = "Rate";
            this.colRate.HeaderText = "Rate/Day";
            this.colRate.MinimumWidth = 6;
            this.colRate.Name = "colRate";
            this.colRate.Width = 150;
            // 
            // colStatus — Available / Occupied / Maintenance
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 150;
            // 
            // colActions — shows "Edit | Delete" links (Admin only)
            // 
            this.colActions.HeaderText = "Actions";
            this.colActions.MinimumWidth = 6;
            this.colActions.Name = "colActions";
            this.colActions.ReadOnly = true;
            this.colActions.Text = "Edit | Delete";
            this.colActions.UseColumnTextForLinkValue = true;
            this.colActions.Width = 180;
            // 
            // lblCount — shows "Total Rooms: N" at the bottom
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(20, 495);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(125, 18);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "Total Rooms: 0";
            // 
            // RoomManagementForm — form setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.cmbStatusFilter);
            this.Controls.Add(this.lblStatusFilter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelHeader);
            this.Name = "RoomManagementForm";
            this.Text = "Room Management";
            this.Load += new System.EventHandler(this.RoomManagementForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.LinkLabel llblNav;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewLinkColumn colActions;
        private System.Windows.Forms.Label lblCount;
    }
}