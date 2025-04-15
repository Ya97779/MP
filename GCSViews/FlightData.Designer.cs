using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    partial class FlightData
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightData));
            this.MainH = new System.Windows.Forms.SplitContainer();
            this.SubMainLeft = new System.Windows.Forms.SplitContainer();
            this.hud1 = new MissionPlanner.Controls.HUD();
            this.contextMenuStripHud = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordHudToAVIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setMJPEGSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGStreamerSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hereLinkVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gStreamerStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAspectRatioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianHudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swapWithMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBatteryCellCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourceHud = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStripactionstab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlactions = new System.Windows.Forms.TabControl();
            this.tabQuick = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelQuick = new System.Windows.Forms.TableLayoutPanel();
            this.quickView6 = new MissionPlanner.Controls.QuickView();
            this.contextMenuStripQuickView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setViewCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourceQuickTab = new System.Windows.Forms.BindingSource(this.components);
            this.quickView5 = new MissionPlanner.Controls.QuickView();
            this.quickView4 = new MissionPlanner.Controls.QuickView();
            this.quickView3 = new MissionPlanner.Controls.QuickView();
            this.quickView2 = new MissionPlanner.Controls.QuickView();
            this.quickView1 = new MissionPlanner.Controls.QuickView();
            this.tabActions = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_SendMSG = new MissionPlanner.Controls.MyButton();
            this.BUT_abortland = new MissionPlanner.Controls.MyButton();
            this.modifyandSetLoiterRad = new MissionPlanner.Controls.ModifyandSet();
            this.BUT_clear_track = new MissionPlanner.Controls.MyButton();
            this.CMB_action = new System.Windows.Forms.ComboBox();
            this.BUTactiondo = new MissionPlanner.Controls.MyButton();
            this.BUT_resumemis = new MissionPlanner.Controls.MyButton();
            this.modifyandSetAlt = new MissionPlanner.Controls.ModifyandSet();
            this.modifyandSetSpeed = new MissionPlanner.Controls.ModifyandSet();
            this.CMB_setwp = new System.Windows.Forms.ComboBox();
            this.BUT_ARM = new MissionPlanner.Controls.MyButton();
            this.BUT_mountmode = new MissionPlanner.Controls.MyButton();
            this.BUT_joystick = new MissionPlanner.Controls.MyButton();
            this.BUT_RAWSensor = new MissionPlanner.Controls.MyButton();
            this.BUT_Homealt = new MissionPlanner.Controls.MyButton();
            this.BUTrestartmission = new MissionPlanner.Controls.MyButton();
            this.CMB_mountmode = new System.Windows.Forms.ComboBox();
            this.BUT_quickrtl = new MissionPlanner.Controls.MyButton();
            this.BUT_quickmanual = new MissionPlanner.Controls.MyButton();
            this.BUT_setwp = new MissionPlanner.Controls.MyButton();
            this.CMB_modes = new System.Windows.Forms.ComboBox();
            this.BUT_quickauto = new MissionPlanner.Controls.MyButton();
            this.BUT_setmode = new MissionPlanner.Controls.MyButton();
            this.tabPagemessages = new System.Windows.Forms.TabPage();
            this.txt_messagebox = new System.Windows.Forms.TextBox();
            this.tabActionsSimple = new System.Windows.Forms.TabPage();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            this.myButton3 = new MissionPlanner.Controls.MyButton();
            this.tabPagePreFlight = new System.Windows.Forms.TabPage();
            this.checkListControl1 = new MissionPlanner.Controls.PreFlight.CheckListControl();
            this.tabGauges = new System.Windows.Forms.TabPage();
            this.Gvspeed = new AGaugeApp.AGauge();
            this.bindingSourceGaugesTab = new System.Windows.Forms.BindingSource(this.components);
            this.Gheading = new MissionPlanner.Controls.HSI();
            this.Galt = new AGaugeApp.AGauge();
            this.Gspeed = new AGaugeApp.AGauge();
            this.tabTransponder = new System.Windows.Forms.TabPage();
            this.NACp_tb = new System.Windows.Forms.TextBox();
            this.NIC_tb = new System.Windows.Forms.TextBox();
            this.NACp_lbl = new System.Windows.Forms.Label();
            this.NIC_lbl = new System.Windows.Forms.Label();
            this.Squawk_nud = new System.Windows.Forms.NumericUpDown();
            this.FlightID_tb = new System.Windows.Forms.TextBox();
            this.fault_clb = new System.Windows.Forms.CheckedListBox();
            this.XPDRConnect_btn = new System.Windows.Forms.Button();
            this.Squawk_label = new System.Windows.Forms.Label();
            this.FlightID_label = new System.Windows.Forms.Label();
            this.IDENT_btn = new System.Windows.Forms.Button();
            this.ALT_btn = new System.Windows.Forms.Button();
            this.STBY_btn = new System.Windows.Forms.Button();
            this.ON_btn = new System.Windows.Forms.Button();
            this.Mode_clb = new System.Windows.Forms.CheckedListBox();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.tabServo = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelServos = new System.Windows.Forms.FlowLayoutPanel();
            this.servoOptions1 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions2 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions3 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions4 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions5 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions6 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions7 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions8 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions9 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions10 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions11 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions12 = new MissionPlanner.Controls.ServoOptions();
            this.relayOptions1 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions2 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions3 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions4 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions5 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions6 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions7 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions8 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions9 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions10 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions11 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions12 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions13 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions14 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions15 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions16 = new MissionPlanner.Controls.RelayOptions();
            this.tabAuxFunction = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.auxOptions1 = new MissionPlanner.Controls.AuxOptions();
            this.auxOptions2 = new MissionPlanner.Controls.AuxOptions();
            this.auxOptions3 = new MissionPlanner.Controls.AuxOptions();
            this.auxOptions4 = new MissionPlanner.Controls.AuxOptions();
            this.auxOptions5 = new MissionPlanner.Controls.AuxOptions();
            this.auxOptions6 = new MissionPlanner.Controls.AuxOptions();
            this.auxOptions7 = new MissionPlanner.Controls.AuxOptions();
            this.tabScripts = new System.Windows.Forms.TabPage();
            this.checkBoxRedirectOutput = new System.Windows.Forms.CheckBox();
            this.BUT_edit_selected = new MissionPlanner.Controls.MyButton();
            this.labelSelectedScript = new System.Windows.Forms.Label();
            this.BUT_run_script = new MissionPlanner.Controls.MyButton();
            this.BUT_abort_script = new MissionPlanner.Controls.MyButton();
            this.labelScriptStatus = new System.Windows.Forms.Label();
            this.BUT_select_script = new MissionPlanner.Controls.MyButton();
            this.tabPayload = new System.Windows.Forms.TabPage();
            this.BUT_GimbalVideo = new MissionPlanner.Controls.MyButton();
            this.groupBoxRoll = new System.Windows.Forms.GroupBox();
            this.TXT_gimbalRollPos = new System.Windows.Forms.TextBox();
            this.bindingSourcePayloadTab = new System.Windows.Forms.BindingSource(this.components);
            this.trackBarRoll = new System.Windows.Forms.TrackBar();
            this.groupBoxYaw = new System.Windows.Forms.GroupBox();
            this.TXT_gimbalYawPos = new System.Windows.Forms.TextBox();
            this.trackBarYaw = new System.Windows.Forms.TrackBar();
            this.BUT_resetGimbalPos = new MissionPlanner.Controls.MyButton();
            this.groupBoxPitch = new System.Windows.Forms.GroupBox();
            this.trackBarPitch = new System.Windows.Forms.TrackBar();
            this.TXT_gimbalPitchPos = new System.Windows.Forms.TextBox();
            this.tabTLogs = new System.Windows.Forms.TabPage();
            this.tableLayoutPaneltlogs = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BUT_speed10 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed5 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed2 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_2 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_4 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_10 = new MissionPlanner.Controls.MyButton();
            this.BUT_loadtelem = new MissionPlanner.Controls.MyButton();
            this.lbl_playbackspeed = new System.Windows.Forms.Label();
            this.lbl_logpercent = new System.Windows.Forms.Label();
            this.LBL_logfn = new System.Windows.Forms.Label();
            this.BUT_log2kml = new MissionPlanner.Controls.MyButton();
            this.BUT_playlog = new MissionPlanner.Controls.MyButton();
            this.tracklog = new System.Windows.Forms.TrackBar();
            this.tablogbrowse = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_DFMavlink = new MissionPlanner.Controls.MyButton();
            this.BUT_georefimage = new MissionPlanner.Controls.MyButton();
            this.BUT_logbrowse = new MissionPlanner.Controls.MyButton();
            this.BUT_matlab = new MissionPlanner.Controls.MyButton();
            this.but_bintolog = new MissionPlanner.Controls.MyButton();
            this.but_dflogtokml = new MissionPlanner.Controls.MyButton();
            this.BUT_loganalysis = new MissionPlanner.Controls.MyButton();
            this.panel_persistent = new System.Windows.Forms.Panel();
            this.tableMap = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.contextMenuStripMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.goHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flyToHereAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flyToCoordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poiatcoordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointCameraHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PointCameraCoordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightPlannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setEKFHomeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeHereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.takeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onOffCameraOverlapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gimbalVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gimbalVideoFullSizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gimbalVideoMiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gimbalVideoPopOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.but_disablejoystick = new MissionPlanner.Controls.MyButton();
            this.Zoomlevel = new System.Windows.Forms.NumericUpDown();
            this.distanceBar1 = new MissionPlanner.Controls.DistanceBar();
            this.TRK_zoom = new MissionPlanner.Controls.MyTrackBar();
            this.windDir1 = new MissionPlanner.Controls.WindDir();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_hdop = new MissionPlanner.Controls.MyLabel();
            this.lbl_sats = new MissionPlanner.Controls.MyLabel();
            this.gMapControl1 = new MissionPlanner.Controls.myGMAP();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.CHK_autopan = new System.Windows.Forms.CheckBox();
            this.CB_tuning = new System.Windows.Forms.CheckBox();
            this.ZedGraphTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openScriptDialog = new System.Windows.Forms.OpenFileDialog();
            this.scriptChecker = new System.Windows.Forms.Timer(this.components);
            this.Messagetabtimer = new System.Windows.Forms.Timer(this.components);
            this.bindingSourceStatusTab = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainH)).BeginInit();
            this.MainH.Panel1.SuspendLayout();
            this.MainH.Panel2.SuspendLayout();
            this.MainH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubMainLeft)).BeginInit();
            this.SubMainLeft.Panel1.SuspendLayout();
            this.SubMainLeft.Panel2.SuspendLayout();
            this.SubMainLeft.SuspendLayout();
            this.contextMenuStripHud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).BeginInit();
            this.contextMenuStripactionstab.SuspendLayout();
            this.tabControlactions.SuspendLayout();
            this.tabQuick.SuspendLayout();
            this.tableLayoutPanelQuick.SuspendLayout();
            this.contextMenuStripQuickView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuickTab)).BeginInit();
            this.tabActions.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPagemessages.SuspendLayout();
            this.tabActionsSimple.SuspendLayout();
            this.tabPagePreFlight.SuspendLayout();
            this.tabGauges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGaugesTab)).BeginInit();
            this.tabTransponder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Squawk_nud)).BeginInit();
            this.tabServo.SuspendLayout();
            this.flowLayoutPanelServos.SuspendLayout();
            this.tabAuxFunction.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabScripts.SuspendLayout();
            this.tabPayload.SuspendLayout();
            this.groupBoxRoll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePayloadTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoll)).BeginInit();
            this.groupBoxYaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYaw)).BeginInit();
            this.groupBoxPitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).BeginInit();
            this.tabTLogs.SuspendLayout();
            this.tableLayoutPaneltlogs.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).BeginInit();
            this.tablogbrowse.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatusTab)).BeginInit();
            this.SuspendLayout();
            // 
            // MainH
            // 
            resources.ApplyResources(this.MainH, "MainH");
            this.MainH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainH.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainH.Name = "MainH";
            // 
            // MainH.Panel1
            // 
            resources.ApplyResources(this.MainH.Panel1, "MainH.Panel1");
            this.MainH.Panel1.Controls.Add(this.SubMainLeft);
            this.toolTip1.SetToolTip(this.MainH.Panel1, resources.GetString("MainH.Panel1.ToolTip"));
            // 
            // MainH.Panel2
            // 
            resources.ApplyResources(this.MainH.Panel2, "MainH.Panel2");
            this.MainH.Panel2.Controls.Add(this.tableMap);
            this.toolTip1.SetToolTip(this.MainH.Panel2, resources.GetString("MainH.Panel2.ToolTip"));
            this.toolTip1.SetToolTip(this.MainH, resources.GetString("MainH.ToolTip"));
            // 
            // SubMainLeft
            // 
            resources.ApplyResources(this.SubMainLeft, "SubMainLeft");
            this.SubMainLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubMainLeft.Name = "SubMainLeft";
            // 
            // SubMainLeft.Panel1
            // 
            resources.ApplyResources(this.SubMainLeft.Panel1, "SubMainLeft.Panel1");
            this.SubMainLeft.Panel1.Controls.Add(this.hud1);
            this.toolTip1.SetToolTip(this.SubMainLeft.Panel1, resources.GetString("SubMainLeft.Panel1.ToolTip"));
            // 
            // SubMainLeft.Panel2
            // 
            resources.ApplyResources(this.SubMainLeft.Panel2, "SubMainLeft.Panel2");
            this.SubMainLeft.Panel2.ContextMenuStrip = this.contextMenuStripactionstab;
            this.SubMainLeft.Panel2.Controls.Add(this.tabControlactions);
            this.SubMainLeft.Panel2.Controls.Add(this.panel_persistent);
            this.toolTip1.SetToolTip(this.SubMainLeft.Panel2, resources.GetString("SubMainLeft.Panel2.ToolTip"));
            this.toolTip1.SetToolTip(this.SubMainLeft, resources.GetString("SubMainLeft.ToolTip"));
            // 
            // hud1
            // 
            resources.ApplyResources(this.hud1, "hud1");
            this.hud1.airspeed = 0F;
            this.hud1.alt = 0F;
            this.hud1.altunit = null;
            this.hud1.AOA = 0F;
            this.hud1.BackColor = System.Drawing.Color.Black;
            this.hud1.batterycellcount = 4;
            this.hud1.batterylevel = 0F;
            this.hud1.batterylevel2 = 0F;
            this.hud1.batteryon2 = true;
            this.hud1.batteryremaining = 0F;
            this.hud1.batteryremaining2 = 0F;
            this.hud1.bgimage = null;
            this.hud1.connected = false;
            this.hud1.ContextMenuStrip = this.contextMenuStripHud;
            this.hud1.critAOA = 25F;
            this.hud1.criticalvoltagealert = false;
            this.hud1.critSSA = 30F;
            this.hud1.current = 0F;
            this.hud1.current2 = 0F;
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("airspeed", this.bindingSourceHud, "airspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("alt", this.bindingSourceHud, "alt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("load", this.bindingSourceHud, "load", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batterylevel", this.bindingSourceHud, "battery_voltage", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batteryremaining", this.bindingSourceHud, "battery_remaining", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("connected", this.bindingSourceHud, "connected", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("current", this.bindingSourceHud, "current", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batterylevel2", this.bindingSourceHud, "battery_voltage2", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batteryremaining2", this.bindingSourceHud, "battery_remaining2", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("current2", this.bindingSourceHud, "current2", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("datetime", this.bindingSourceHud, "datetime", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("disttowp", this.bindingSourceHud, "wp_dist", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("ekfstatus", this.bindingSourceHud, "ekfstatus", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("failsafe", this.bindingSourceHud, "failsafe", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpsfix", this.bindingSourceHud, "gpsstatus", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpsfix2", this.bindingSourceHud, "gpsstatus2", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpshdop", this.bindingSourceHud, "gpshdop", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpshdop2", this.bindingSourceHud, "gpshdop2", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundalt", this.bindingSourceHud, "HomeAlt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundcourse", this.bindingSourceHud, "groundcourse", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundspeed", this.bindingSourceHud, "groundspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("heading", this.bindingSourceHud, "yaw", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("linkqualitygcs", this.bindingSourceHud, "linkqualitygcs", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("message", this.bindingSourceHud, "messageHigh", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("messageSeverity", this.bindingSourceHud, "messageHighSeverity", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("mode", this.bindingSourceHud, "mode", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("navpitch", this.bindingSourceHud, "nav_pitch", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("navroll", this.bindingSourceHud, "nav_roll", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("pitch", this.bindingSourceHud, "pitch", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("prearmstatus", this.bindingSourceHud, "prearmstatus", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("roll", this.bindingSourceHud, "roll", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("safetyactive", this.bindingSourceHud, "safetyactive", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("status", this.bindingSourceHud, "armed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetalt", this.bindingSourceHud, "targetalt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetheading", this.bindingSourceHud, "nav_bearing", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetspeed", this.bindingSourceHud, "targetairspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("turnrate", this.bindingSourceHud, "turnrate", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("verticalspeed", this.bindingSourceHud, "verticalspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibex", this.bindingSourceHud, "vibex", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibey", this.bindingSourceHud, "vibey", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibez", this.bindingSourceHud, "vibez", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("wpno", this.bindingSourceHud, "wpno", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("xtrack_error", this.bindingSourceHud, "xtrack_error", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("AOA", this.bindingSourceHud, "AOA", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("SSA", this.bindingSourceHud, "SSA", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("critAOA", this.bindingSourceHud, "crit_AOA", true));
            this.hud1.datetime = new System.DateTime(((long)(0)));
            this.hud1.displayAOASSA = false;
            this.hud1.displayCellVoltage = false;
            this.hud1.displayicons = false;
            this.hud1.disttowp = 0F;
            this.hud1.distunit = null;
            this.hud1.ekfstatus = 0F;
            this.hud1.failsafe = false;
            this.hud1.gpsfix = 0F;
            this.hud1.gpsfix2 = 0F;
            this.hud1.gpshdop = 0F;
            this.hud1.gpshdop2 = 0F;
            this.hud1.groundalt = 0F;
            this.hud1.groundcourse = 0F;
            this.hud1.groundspeed = 0F;
            this.hud1.heading = 0F;
            this.hud1.hudcolor = System.Drawing.Color.LightGray;
            this.hud1.linkqualitygcs = 0F;
            this.hud1.load = 0F;
            this.hud1.lowairspeed = false;
            this.hud1.lowgroundspeed = false;
            this.hud1.lowvoltagealert = false;
            this.hud1.message = "";
            this.hud1.messageSeverity = MAVLink.MAV_SEVERITY.EMERGENCY;
            this.hud1.mode = "Unknown";
            this.hud1.Name = "hud1";
            this.hud1.navpitch = 0F;
            this.hud1.navroll = 0F;
            this.hud1.pitch = 0F;
            this.hud1.prearmstatus = false;
            this.hud1.roll = 0F;
            this.hud1.Russian = false;
            this.hud1.safetyactive = false;
            this.hud1.skyColor1 = System.Drawing.Color.Blue;
            this.hud1.skyColor2 = System.Drawing.Color.LightBlue;
            this.hud1.speedunit = null;
            this.hud1.SSA = 0F;
            this.hud1.status = false;
            this.hud1.targetalt = 0F;
            this.hud1.targetheading = 0F;
            this.hud1.targetspeed = 0F;
            this.toolTip1.SetToolTip(this.hud1, resources.GetString("hud1.ToolTip"));
            this.hud1.turnrate = 0F;
            this.hud1.verticalspeed = 0F;
            this.hud1.vibex = 0F;
            this.hud1.vibey = 0F;
            this.hud1.vibez = 0F;
            this.hud1.VSync = false;
            this.hud1.wpno = 0;
            this.hud1.xtrack_error = 0F;
            this.hud1.ekfclick += new System.EventHandler(this.hud1_ekfclick);
            this.hud1.vibeclick += new System.EventHandler(this.hud1_vibeclick);
            this.hud1.prearmclick += new System.EventHandler(this.hud1_prearmclick);
            this.hud1.Load += new System.EventHandler(this.hud1_Load);
            this.hud1.DoubleClick += new System.EventHandler(this.hud1_DoubleClick);
            this.hud1.Resize += new System.EventHandler(this.hud1_Resize);
            // 
            // contextMenuStripHud
            // 
            resources.ApplyResources(this.contextMenuStripHud, "contextMenuStripHud");
            this.contextMenuStripHud.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripHud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoToolStripMenuItem,
            this.setAspectRatioToolStripMenuItem,
            this.userItemsToolStripMenuItem,
            this.russianHudToolStripMenuItem,
            this.swapWithMapToolStripMenuItem,
            this.groundColorToolStripMenuItem,
            this.setBatteryCellCountToolStripMenuItem,
            this.showIconsToolStripMenuItem});
            this.contextMenuStripHud.Name = "contextMenuStrip2";
            this.toolTip1.SetToolTip(this.contextMenuStripHud, resources.GetString("contextMenuStripHud.ToolTip"));
            // 
            // videoToolStripMenuItem
            // 
            resources.ApplyResources(this.videoToolStripMenuItem, "videoToolStripMenuItem");
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordHudToAVIToolStripMenuItem,
            this.stopRecordToolStripMenuItem,
            this.setMJPEGSourceToolStripMenuItem,
            this.startCameraToolStripMenuItem,
            this.setGStreamerSourceToolStripMenuItem,
            this.hereLinkVideoToolStripMenuItem,
            this.gStreamerStopToolStripMenuItem});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            // 
            // recordHudToAVIToolStripMenuItem
            // 
            resources.ApplyResources(this.recordHudToAVIToolStripMenuItem, "recordHudToAVIToolStripMenuItem");
            this.recordHudToAVIToolStripMenuItem.Name = "recordHudToAVIToolStripMenuItem";
            this.recordHudToAVIToolStripMenuItem.Click += new System.EventHandler(this.recordHudToAVIToolStripMenuItem_Click);
            // 
            // stopRecordToolStripMenuItem
            // 
            resources.ApplyResources(this.stopRecordToolStripMenuItem, "stopRecordToolStripMenuItem");
            this.stopRecordToolStripMenuItem.Name = "stopRecordToolStripMenuItem";
            this.stopRecordToolStripMenuItem.Click += new System.EventHandler(this.stopRecordToolStripMenuItem_Click);
            // 
            // setMJPEGSourceToolStripMenuItem
            // 
            resources.ApplyResources(this.setMJPEGSourceToolStripMenuItem, "setMJPEGSourceToolStripMenuItem");
            this.setMJPEGSourceToolStripMenuItem.Name = "setMJPEGSourceToolStripMenuItem";
            this.setMJPEGSourceToolStripMenuItem.Click += new System.EventHandler(this.setMJPEGSourceToolStripMenuItem_Click);
            // 
            // startCameraToolStripMenuItem
            // 
            resources.ApplyResources(this.startCameraToolStripMenuItem, "startCameraToolStripMenuItem");
            this.startCameraToolStripMenuItem.Name = "startCameraToolStripMenuItem";
            this.startCameraToolStripMenuItem.Click += new System.EventHandler(this.startCameraToolStripMenuItem_Click);
            // 
            // setGStreamerSourceToolStripMenuItem
            // 
            resources.ApplyResources(this.setGStreamerSourceToolStripMenuItem, "setGStreamerSourceToolStripMenuItem");
            this.setGStreamerSourceToolStripMenuItem.Name = "setGStreamerSourceToolStripMenuItem";
            this.setGStreamerSourceToolStripMenuItem.Click += new System.EventHandler(this.setGStreamerSourceToolStripMenuItem_Click);
            // 
            // hereLinkVideoToolStripMenuItem
            // 
            resources.ApplyResources(this.hereLinkVideoToolStripMenuItem, "hereLinkVideoToolStripMenuItem");
            this.hereLinkVideoToolStripMenuItem.Name = "hereLinkVideoToolStripMenuItem";
            this.hereLinkVideoToolStripMenuItem.Click += new System.EventHandler(this.HereLinkVideoToolStripMenuItem_Click);
            // 
            // gStreamerStopToolStripMenuItem
            // 
            resources.ApplyResources(this.gStreamerStopToolStripMenuItem, "gStreamerStopToolStripMenuItem");
            this.gStreamerStopToolStripMenuItem.Name = "gStreamerStopToolStripMenuItem";
            this.gStreamerStopToolStripMenuItem.Click += new System.EventHandler(this.GStreamerStopToolStripMenuItem_Click);
            // 
            // setAspectRatioToolStripMenuItem
            // 
            resources.ApplyResources(this.setAspectRatioToolStripMenuItem, "setAspectRatioToolStripMenuItem");
            this.setAspectRatioToolStripMenuItem.Name = "setAspectRatioToolStripMenuItem";
            this.setAspectRatioToolStripMenuItem.Click += new System.EventHandler(this.setAspectRatioToolStripMenuItem_Click);
            // 
            // userItemsToolStripMenuItem
            // 
            resources.ApplyResources(this.userItemsToolStripMenuItem, "userItemsToolStripMenuItem");
            this.userItemsToolStripMenuItem.Name = "userItemsToolStripMenuItem";
            this.userItemsToolStripMenuItem.Click += new System.EventHandler(this.hud_UserItem);
            // 
            // russianHudToolStripMenuItem
            // 
            resources.ApplyResources(this.russianHudToolStripMenuItem, "russianHudToolStripMenuItem");
            this.russianHudToolStripMenuItem.Name = "russianHudToolStripMenuItem";
            this.russianHudToolStripMenuItem.Click += new System.EventHandler(this.russianHudToolStripMenuItem_Click);
            // 
            // swapWithMapToolStripMenuItem
            // 
            resources.ApplyResources(this.swapWithMapToolStripMenuItem, "swapWithMapToolStripMenuItem");
            this.swapWithMapToolStripMenuItem.Name = "swapWithMapToolStripMenuItem";
            this.swapWithMapToolStripMenuItem.Click += new System.EventHandler(this.swapWithMapToolStripMenuItem_Click);
            // 
            // groundColorToolStripMenuItem
            // 
            resources.ApplyResources(this.groundColorToolStripMenuItem, "groundColorToolStripMenuItem");
            this.groundColorToolStripMenuItem.CheckOnClick = true;
            this.groundColorToolStripMenuItem.Name = "groundColorToolStripMenuItem";
            this.groundColorToolStripMenuItem.Click += new System.EventHandler(this.groundColorToolStripMenuItem_Click);
            // 
            // setBatteryCellCountToolStripMenuItem
            // 
            resources.ApplyResources(this.setBatteryCellCountToolStripMenuItem, "setBatteryCellCountToolStripMenuItem");
            this.setBatteryCellCountToolStripMenuItem.Name = "setBatteryCellCountToolStripMenuItem";
            this.setBatteryCellCountToolStripMenuItem.Click += new System.EventHandler(this.setBatteryCellCountToolStripMenuItem_Click);
            // 
            // showIconsToolStripMenuItem
            // 
            resources.ApplyResources(this.showIconsToolStripMenuItem, "showIconsToolStripMenuItem");
            this.showIconsToolStripMenuItem.Name = "showIconsToolStripMenuItem";
            this.showIconsToolStripMenuItem.Click += new System.EventHandler(this.showIconsToolStripMenuItem_Click);
            // 
            // bindingSourceHud
            // 
            this.bindingSourceHud.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // contextMenuStripactionstab
            // 
            resources.ApplyResources(this.contextMenuStripactionstab, "contextMenuStripactionstab");
            this.contextMenuStripactionstab.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripactionstab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.multiLineToolStripMenuItem});
            this.contextMenuStripactionstab.Name = "contextMenuStripactionstab";
            this.toolTip1.SetToolTip(this.contextMenuStripactionstab, resources.GetString("contextMenuStripactionstab.ToolTip"));
            // 
            // customizeToolStripMenuItem
            // 
            resources.ApplyResources(this.customizeToolStripMenuItem, "customizeToolStripMenuItem");
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // multiLineToolStripMenuItem
            // 
            resources.ApplyResources(this.multiLineToolStripMenuItem, "multiLineToolStripMenuItem");
            this.multiLineToolStripMenuItem.Name = "multiLineToolStripMenuItem";
            this.multiLineToolStripMenuItem.Click += new System.EventHandler(this.multiLineToolStripMenuItem_Click);
            // 
            // tabControlactions
            // 
            resources.ApplyResources(this.tabControlactions, "tabControlactions");
            this.tabControlactions.ContextMenuStrip = this.contextMenuStripactionstab;
            this.tabControlactions.Controls.Add(this.tabQuick);
            this.tabControlactions.Controls.Add(this.tabActions);
            this.tabControlactions.Controls.Add(this.tabPagemessages);
            this.tabControlactions.Controls.Add(this.tabActionsSimple);
            this.tabControlactions.Controls.Add(this.tabPagePreFlight);
            this.tabControlactions.Controls.Add(this.tabGauges);
            this.tabControlactions.Controls.Add(this.tabTransponder);
            this.tabControlactions.Controls.Add(this.tabStatus);
            this.tabControlactions.Controls.Add(this.tabServo);
            this.tabControlactions.Controls.Add(this.tabAuxFunction);
            this.tabControlactions.Controls.Add(this.tabScripts);
            this.tabControlactions.Controls.Add(this.tabPayload);
            this.tabControlactions.Controls.Add(this.tabTLogs);
            this.tabControlactions.Controls.Add(this.tablogbrowse);
            this.tabControlactions.Name = "tabControlactions";
            this.tabControlactions.SelectedIndex = 0;
            this.toolTip1.SetToolTip(this.tabControlactions, resources.GetString("tabControlactions.ToolTip"));
            this.tabControlactions.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControlactions.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabQuick
            // 
            resources.ApplyResources(this.tabQuick, "tabQuick");
            this.tabQuick.Controls.Add(this.tableLayoutPanelQuick);
            this.tabQuick.Name = "tabQuick";
            this.toolTip1.SetToolTip(this.tabQuick, resources.GetString("tabQuick.ToolTip"));
            this.tabQuick.UseVisualStyleBackColor = true;
            this.tabQuick.Resize += new System.EventHandler(this.tabQuick_Resize);
            // 
            // tableLayoutPanelQuick
            // 
            resources.ApplyResources(this.tableLayoutPanelQuick, "tableLayoutPanelQuick");
            this.tableLayoutPanelQuick.Controls.Add(this.quickView6, 1, 2);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView5, 0, 2);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView4, 1, 1);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView3, 0, 1);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView2, 1, 0);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView1, 0, 0);
            this.tableLayoutPanelQuick.Name = "tableLayoutPanelQuick";
            this.toolTip1.SetToolTip(this.tableLayoutPanelQuick, resources.GetString("tableLayoutPanelQuick.ToolTip"));
            // 
            // quickView6
            // 
            resources.ApplyResources(this.quickView6, "quickView6");
            this.quickView6.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView6.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "DistToHome", true));
            this.quickView6.desc = "DistToMAV";
            this.quickView6.Name = "quickView6";
            this.quickView6.number = 0D;
            this.quickView6.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.quickView6.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView6.numberformat = "0.00";
            this.toolTip1.SetToolTip(this.quickView6, resources.GetString("quickView6.ToolTip"));
            this.quickView6.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // contextMenuStripQuickView
            // 
            resources.ApplyResources(this.contextMenuStripQuickView, "contextMenuStripQuickView");
            this.contextMenuStripQuickView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripQuickView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setViewCountToolStripMenuItem,
            this.undockToolStripMenuItem});
            this.contextMenuStripQuickView.Name = "contextMenuStripQuickView";
            this.toolTip1.SetToolTip(this.contextMenuStripQuickView, resources.GetString("contextMenuStripQuickView.ToolTip"));
            // 
            // setViewCountToolStripMenuItem
            // 
            resources.ApplyResources(this.setViewCountToolStripMenuItem, "setViewCountToolStripMenuItem");
            this.setViewCountToolStripMenuItem.Name = "setViewCountToolStripMenuItem";
            this.setViewCountToolStripMenuItem.Click += new System.EventHandler(this.setViewCountToolStripMenuItem_Click);
            // 
            // undockToolStripMenuItem
            // 
            resources.ApplyResources(this.undockToolStripMenuItem, "undockToolStripMenuItem");
            this.undockToolStripMenuItem.Name = "undockToolStripMenuItem";
            this.undockToolStripMenuItem.Click += new System.EventHandler(this.undockDockToolStripMenuItem_Click);
            // 
            // bindingSourceQuickTab
            // 
            this.bindingSourceQuickTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // quickView5
            // 
            resources.ApplyResources(this.quickView5, "quickView5");
            this.quickView5.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView5.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "verticalspeed", true));
            this.quickView5.desc = "verticalspeed";
            this.quickView5.Name = "quickView5";
            this.quickView5.number = 0D;
            this.quickView5.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(86)))));
            this.quickView5.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView5.numberformat = "0.00";
            this.toolTip1.SetToolTip(this.quickView5, resources.GetString("quickView5.ToolTip"));
            this.quickView5.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView4
            // 
            resources.ApplyResources(this.quickView4, "quickView4");
            this.quickView4.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView4.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "yaw", true));
            this.quickView4.desc = "yaw";
            this.quickView4.Name = "quickView4";
            this.quickView4.number = 0D;
            this.quickView4.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(83)))));
            this.quickView4.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView4.numberformat = "0.00";
            this.toolTip1.SetToolTip(this.quickView4, resources.GetString("quickView4.ToolTip"));
            this.quickView4.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView3
            // 
            resources.ApplyResources(this.quickView3, "quickView3");
            this.quickView3.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView3.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "wp_dist", true));
            this.quickView3.desc = "wp_dist";
            this.quickView3.Name = "quickView3";
            this.quickView3.number = 0D;
            this.quickView3.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(91)))));
            this.quickView3.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView3.numberformat = "0.00";
            this.toolTip1.SetToolTip(this.quickView3, resources.GetString("quickView3.ToolTip"));
            this.quickView3.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView2
            // 
            resources.ApplyResources(this.quickView2, "quickView2");
            this.quickView2.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView2.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "groundspeed", true));
            this.quickView2.desc = "groundspeed";
            this.quickView2.Name = "quickView2";
            this.quickView2.number = 0D;
            this.quickView2.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(132)))), ((int)(((byte)(46)))));
            this.quickView2.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView2.numberformat = "0.00";
            this.toolTip1.SetToolTip(this.quickView2, resources.GetString("quickView2.ToolTip"));
            this.quickView2.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView1
            // 
            resources.ApplyResources(this.quickView1, "quickView1");
            this.quickView1.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView1.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "alt", true));
            this.quickView1.desc = "alt";
            this.quickView1.Name = "quickView1";
            this.quickView1.number = 0D;
            this.quickView1.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(151)))), ((int)(((byte)(248)))));
            this.quickView1.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView1.numberformat = "0.00";
            this.toolTip1.SetToolTip(this.quickView1, resources.GetString("quickView1.ToolTip"));
            this.quickView1.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // tabActions
            // 
            resources.ApplyResources(this.tabActions, "tabActions");
            this.tabActions.Controls.Add(this.tableLayoutPanel1);
            this.tabActions.Name = "tabActions";
            this.toolTip1.SetToolTip(this.tabActions, resources.GetString("tabActions.ToolTip"));
            this.tabActions.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.BUT_SendMSG, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.BUT_abortland, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.modifyandSetLoiterRad, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.BUT_clear_track, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.CMB_action, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BUTactiondo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BUT_resumemis, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.modifyandSetAlt, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.modifyandSetSpeed, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.CMB_setwp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BUT_ARM, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.BUT_mountmode, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BUT_joystick, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.BUT_RAWSensor, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.BUT_Homealt, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BUTrestartmission, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.CMB_mountmode, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BUT_quickrtl, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BUT_quickmanual, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BUT_setwp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CMB_modes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BUT_quickauto, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BUT_setmode, 1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.toolTip1.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // BUT_SendMSG
            // 
            resources.ApplyResources(this.BUT_SendMSG, "BUT_SendMSG");
            this.BUT_SendMSG.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_SendMSG.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_SendMSG.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_SendMSG.Name = "BUT_SendMSG";
            this.BUT_SendMSG.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_SendMSG, resources.GetString("BUT_SendMSG.ToolTip"));
            this.BUT_SendMSG.UseVisualStyleBackColor = true;
            this.BUT_SendMSG.Click += new System.EventHandler(this.BUT_SendMSG_Click);
            // 
            // BUT_abortland
            // 
            resources.ApplyResources(this.BUT_abortland, "BUT_abortland");
            this.BUT_abortland.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_abortland.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_abortland.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_abortland.Name = "BUT_abortland";
            this.BUT_abortland.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_abortland, resources.GetString("BUT_abortland.ToolTip"));
            this.BUT_abortland.UseVisualStyleBackColor = true;
            this.BUT_abortland.Click += new System.EventHandler(this.BUT_abortland_Click);
            // 
            // modifyandSetLoiterRad
            // 
            resources.ApplyResources(this.modifyandSetLoiterRad, "modifyandSetLoiterRad");
            this.modifyandSetLoiterRad.ButtonText = "Set Loiter Rad";
            this.modifyandSetLoiterRad.DecimalPlaces = 0;
            this.modifyandSetLoiterRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.modifyandSetLoiterRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.modifyandSetLoiterRad.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.modifyandSetLoiterRad.Name = "modifyandSetLoiterRad";
            this.toolTip1.SetToolTip(this.modifyandSetLoiterRad, resources.GetString("modifyandSetLoiterRad.ToolTip"));
            this.modifyandSetLoiterRad.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modifyandSetLoiterRad.Click += new System.EventHandler(this.modifyandSetLoiterRad_Click);
            // 
            // BUT_clear_track
            // 
            resources.ApplyResources(this.BUT_clear_track, "BUT_clear_track");
            this.BUT_clear_track.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_clear_track.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_clear_track.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_clear_track.Name = "BUT_clear_track";
            this.BUT_clear_track.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_clear_track, resources.GetString("BUT_clear_track.ToolTip"));
            this.BUT_clear_track.UseVisualStyleBackColor = true;
            this.BUT_clear_track.Click += new System.EventHandler(this.BUT_clear_track_Click);
            // 
            // CMB_action
            // 
            resources.ApplyResources(this.CMB_action, "CMB_action");
            this.CMB_action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_action.DropDownWidth = 250;
            this.CMB_action.FormattingEnabled = true;
            this.CMB_action.Name = "CMB_action";
            this.toolTip1.SetToolTip(this.CMB_action, resources.GetString("CMB_action.ToolTip"));
            // 
            // BUTactiondo
            // 
            resources.ApplyResources(this.BUTactiondo, "BUTactiondo");
            this.BUTactiondo.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUTactiondo.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUTactiondo.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUTactiondo.Name = "BUTactiondo";
            this.BUTactiondo.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUTactiondo, resources.GetString("BUTactiondo.ToolTip"));
            this.BUTactiondo.UseVisualStyleBackColor = true;
            this.BUTactiondo.Click += new System.EventHandler(this.BUTactiondo_Click);
            // 
            // BUT_resumemis
            // 
            resources.ApplyResources(this.BUT_resumemis, "BUT_resumemis");
            this.BUT_resumemis.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_resumemis.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_resumemis.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_resumemis.Name = "BUT_resumemis";
            this.BUT_resumemis.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_resumemis, resources.GetString("BUT_resumemis.ToolTip"));
            this.BUT_resumemis.UseVisualStyleBackColor = true;
            this.BUT_resumemis.Click += new System.EventHandler(this.BUT_resumemis_Click);
            // 
            // modifyandSetAlt
            // 
            resources.ApplyResources(this.modifyandSetAlt, "modifyandSetAlt");
            this.modifyandSetAlt.ButtonText = "Change Alt";
            this.modifyandSetAlt.DecimalPlaces = 1;
            this.modifyandSetAlt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.modifyandSetAlt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.modifyandSetAlt.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.modifyandSetAlt.Name = "modifyandSetAlt";
            this.toolTip1.SetToolTip(this.modifyandSetAlt, resources.GetString("modifyandSetAlt.ToolTip"));
            this.modifyandSetAlt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modifyandSetAlt.Click += new System.EventHandler(this.modifyandSetAlt_Click);
            // 
            // modifyandSetSpeed
            // 
            resources.ApplyResources(this.modifyandSetSpeed, "modifyandSetSpeed");
            this.modifyandSetSpeed.ButtonText = "Change Speed";
            this.modifyandSetSpeed.DecimalPlaces = 1;
            this.modifyandSetSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.modifyandSetSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.modifyandSetSpeed.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.modifyandSetSpeed.Name = "modifyandSetSpeed";
            this.toolTip1.SetToolTip(this.modifyandSetSpeed, resources.GetString("modifyandSetSpeed.ToolTip"));
            this.modifyandSetSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modifyandSetSpeed.Click += new System.EventHandler(this.modifyandSetSpeed_Click);
            this.modifyandSetSpeed.ParentChanged += new System.EventHandler(this.modifyandSetSpeed_ParentChanged);
            // 
            // CMB_setwp
            // 
            resources.ApplyResources(this.CMB_setwp, "CMB_setwp");
            this.CMB_setwp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_setwp.DropDownWidth = 150;
            this.CMB_setwp.FormattingEnabled = true;
            this.CMB_setwp.Items.AddRange(new object[] {
            resources.GetString("CMB_setwp.Items")});
            this.CMB_setwp.Name = "CMB_setwp";
            this.toolTip1.SetToolTip(this.CMB_setwp, resources.GetString("CMB_setwp.ToolTip"));
            this.CMB_setwp.Click += new System.EventHandler(this.CMB_setwp_Click);
            // 
            // BUT_ARM
            // 
            resources.ApplyResources(this.BUT_ARM, "BUT_ARM");
            this.BUT_ARM.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_ARM.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_ARM.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_ARM.Name = "BUT_ARM";
            this.BUT_ARM.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_ARM, resources.GetString("BUT_ARM.ToolTip"));
            this.BUT_ARM.UseVisualStyleBackColor = true;
            this.BUT_ARM.Click += new System.EventHandler(this.BUT_ARM_Click);
            // 
            // BUT_mountmode
            // 
            resources.ApplyResources(this.BUT_mountmode, "BUT_mountmode");
            this.BUT_mountmode.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_mountmode.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_mountmode.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_mountmode.Name = "BUT_mountmode";
            this.BUT_mountmode.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_mountmode, resources.GetString("BUT_mountmode.ToolTip"));
            this.BUT_mountmode.UseVisualStyleBackColor = true;
            this.BUT_mountmode.Click += new System.EventHandler(this.BUT_mountmode_Click);
            // 
            // BUT_joystick
            // 
            resources.ApplyResources(this.BUT_joystick, "BUT_joystick");
            this.BUT_joystick.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_joystick.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_joystick.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_joystick.Name = "BUT_joystick";
            this.BUT_joystick.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_joystick, resources.GetString("BUT_joystick.ToolTip"));
            this.BUT_joystick.UseVisualStyleBackColor = true;
            this.BUT_joystick.Click += new System.EventHandler(this.BUT_joystick_Click);
            // 
            // BUT_RAWSensor
            // 
            resources.ApplyResources(this.BUT_RAWSensor, "BUT_RAWSensor");
            this.BUT_RAWSensor.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_RAWSensor.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_RAWSensor.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_RAWSensor.Name = "BUT_RAWSensor";
            this.BUT_RAWSensor.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_RAWSensor, resources.GetString("BUT_RAWSensor.ToolTip"));
            this.BUT_RAWSensor.UseVisualStyleBackColor = true;
            this.BUT_RAWSensor.Click += new System.EventHandler(this.BUT_RAWSensor_Click);
            // 
            // BUT_Homealt
            // 
            resources.ApplyResources(this.BUT_Homealt, "BUT_Homealt");
            this.BUT_Homealt.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_Homealt.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_Homealt.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_Homealt.Name = "BUT_Homealt";
            this.BUT_Homealt.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_Homealt, resources.GetString("BUT_Homealt.ToolTip"));
            this.BUT_Homealt.UseVisualStyleBackColor = true;
            this.BUT_Homealt.Click += new System.EventHandler(this.BUT_Homealt_Click);
            // 
            // BUTrestartmission
            // 
            resources.ApplyResources(this.BUTrestartmission, "BUTrestartmission");
            this.BUTrestartmission.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUTrestartmission.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUTrestartmission.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUTrestartmission.Name = "BUTrestartmission";
            this.BUTrestartmission.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUTrestartmission, resources.GetString("BUTrestartmission.ToolTip"));
            this.BUTrestartmission.UseVisualStyleBackColor = true;
            this.BUTrestartmission.Click += new System.EventHandler(this.BUTrestartmission_Click);
            // 
            // CMB_mountmode
            // 
            resources.ApplyResources(this.CMB_mountmode, "CMB_mountmode");
            this.CMB_mountmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_mountmode.DropDownWidth = 150;
            this.CMB_mountmode.FormattingEnabled = true;
            this.CMB_mountmode.Name = "CMB_mountmode";
            this.toolTip1.SetToolTip(this.CMB_mountmode, resources.GetString("CMB_mountmode.ToolTip"));
            // 
            // BUT_quickrtl
            // 
            resources.ApplyResources(this.BUT_quickrtl, "BUT_quickrtl");
            this.BUT_quickrtl.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_quickrtl.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_quickrtl.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_quickrtl.Name = "BUT_quickrtl";
            this.BUT_quickrtl.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_quickrtl, resources.GetString("BUT_quickrtl.ToolTip"));
            this.BUT_quickrtl.UseVisualStyleBackColor = true;
            this.BUT_quickrtl.Click += new System.EventHandler(this.BUT_quickrtl_Click);
            // 
            // BUT_quickmanual
            // 
            resources.ApplyResources(this.BUT_quickmanual, "BUT_quickmanual");
            this.BUT_quickmanual.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_quickmanual.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_quickmanual.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_quickmanual.Name = "BUT_quickmanual";
            this.BUT_quickmanual.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_quickmanual, resources.GetString("BUT_quickmanual.ToolTip"));
            this.BUT_quickmanual.UseVisualStyleBackColor = true;
            this.BUT_quickmanual.Click += new System.EventHandler(this.BUT_quickmanual_Click);
            // 
            // BUT_setwp
            // 
            resources.ApplyResources(this.BUT_setwp, "BUT_setwp");
            this.BUT_setwp.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_setwp.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_setwp.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_setwp.Name = "BUT_setwp";
            this.BUT_setwp.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_setwp, resources.GetString("BUT_setwp.ToolTip"));
            this.BUT_setwp.UseVisualStyleBackColor = true;
            this.BUT_setwp.Click += new System.EventHandler(this.BUT_setwp_Click);
            // 
            // CMB_modes
            // 
            resources.ApplyResources(this.CMB_modes, "CMB_modes");
            this.CMB_modes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_modes.DropDownWidth = 150;
            this.CMB_modes.FormattingEnabled = true;
            this.CMB_modes.Name = "CMB_modes";
            this.toolTip1.SetToolTip(this.CMB_modes, resources.GetString("CMB_modes.ToolTip"));
            this.CMB_modes.Click += new System.EventHandler(this.CMB_modes_Click);
            // 
            // BUT_quickauto
            // 
            resources.ApplyResources(this.BUT_quickauto, "BUT_quickauto");
            this.BUT_quickauto.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_quickauto.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_quickauto.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_quickauto.Name = "BUT_quickauto";
            this.BUT_quickauto.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_quickauto, resources.GetString("BUT_quickauto.ToolTip"));
            this.BUT_quickauto.UseVisualStyleBackColor = true;
            this.BUT_quickauto.Click += new System.EventHandler(this.BUT_quickauto_Click);
            // 
            // BUT_setmode
            // 
            resources.ApplyResources(this.BUT_setmode, "BUT_setmode");
            this.BUT_setmode.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_setmode.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_setmode.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_setmode.Name = "BUT_setmode";
            this.BUT_setmode.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_setmode, resources.GetString("BUT_setmode.ToolTip"));
            this.BUT_setmode.UseVisualStyleBackColor = true;
            this.BUT_setmode.Click += new System.EventHandler(this.BUT_setmode_Click);
            // 
            // tabPagemessages
            // 
            resources.ApplyResources(this.tabPagemessages, "tabPagemessages");
            this.tabPagemessages.Controls.Add(this.txt_messagebox);
            this.tabPagemessages.Name = "tabPagemessages";
            this.toolTip1.SetToolTip(this.tabPagemessages, resources.GetString("tabPagemessages.ToolTip"));
            this.tabPagemessages.UseVisualStyleBackColor = true;
            // 
            // txt_messagebox
            // 
            resources.ApplyResources(this.txt_messagebox, "txt_messagebox");
            this.txt_messagebox.Name = "txt_messagebox";
            this.toolTip1.SetToolTip(this.txt_messagebox, resources.GetString("txt_messagebox.ToolTip"));
            // 
            // tabActionsSimple
            // 
            resources.ApplyResources(this.tabActionsSimple, "tabActionsSimple");
            this.tabActionsSimple.Controls.Add(this.myButton1);
            this.tabActionsSimple.Controls.Add(this.myButton2);
            this.tabActionsSimple.Controls.Add(this.myButton3);
            this.tabActionsSimple.Name = "tabActionsSimple";
            this.toolTip1.SetToolTip(this.tabActionsSimple, resources.GetString("tabActionsSimple.ToolTip"));
            this.tabActionsSimple.UseVisualStyleBackColor = true;
            // 
            // myButton1
            // 
            resources.ApplyResources(this.myButton1, "myButton1");
            this.myButton1.ColorMouseDown = System.Drawing.Color.Empty;
            this.myButton1.ColorMouseOver = System.Drawing.Color.Empty;
            this.myButton1.ColorNotEnabled = System.Drawing.Color.Empty;
            this.myButton1.Name = "myButton1";
            this.myButton1.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.myButton1, resources.GetString("myButton1.ToolTip"));
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.BUT_quickmanual_Click);
            // 
            // myButton2
            // 
            resources.ApplyResources(this.myButton2, "myButton2");
            this.myButton2.ColorMouseDown = System.Drawing.Color.Empty;
            this.myButton2.ColorMouseOver = System.Drawing.Color.Empty;
            this.myButton2.ColorNotEnabled = System.Drawing.Color.Empty;
            this.myButton2.Name = "myButton2";
            this.myButton2.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.myButton2, resources.GetString("myButton2.ToolTip"));
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.BUT_quickrtl_Click);
            // 
            // myButton3
            // 
            resources.ApplyResources(this.myButton3, "myButton3");
            this.myButton3.ColorMouseDown = System.Drawing.Color.Empty;
            this.myButton3.ColorMouseOver = System.Drawing.Color.Empty;
            this.myButton3.ColorNotEnabled = System.Drawing.Color.Empty;
            this.myButton3.Name = "myButton3";
            this.myButton3.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.myButton3, resources.GetString("myButton3.ToolTip"));
            this.myButton3.UseVisualStyleBackColor = true;
            this.myButton3.Click += new System.EventHandler(this.BUT_quickauto_Click);
            // 
            // tabPagePreFlight
            // 
            resources.ApplyResources(this.tabPagePreFlight, "tabPagePreFlight");
            this.tabPagePreFlight.Controls.Add(this.checkListControl1);
            this.tabPagePreFlight.Name = "tabPagePreFlight";
            this.toolTip1.SetToolTip(this.tabPagePreFlight, resources.GetString("tabPagePreFlight.ToolTip"));
            this.tabPagePreFlight.UseVisualStyleBackColor = true;
            // 
            // checkListControl1
            // 
            resources.ApplyResources(this.checkListControl1, "checkListControl1");
            this.checkListControl1.Name = "checkListControl1";
            this.toolTip1.SetToolTip(this.checkListControl1, resources.GetString("checkListControl1.ToolTip"));
            // 
            // tabGauges
            // 
            resources.ApplyResources(this.tabGauges, "tabGauges");
            this.tabGauges.Controls.Add(this.Gvspeed);
            this.tabGauges.Controls.Add(this.Gheading);
            this.tabGauges.Controls.Add(this.Galt);
            this.tabGauges.Controls.Add(this.Gspeed);
            this.tabGauges.Name = "tabGauges";
            this.toolTip1.SetToolTip(this.tabGauges, resources.GetString("tabGauges.ToolTip"));
            this.tabGauges.UseVisualStyleBackColor = true;
            this.tabGauges.Resize += new System.EventHandler(this.tabPage1_Resize);
            // 
            // Gvspeed
            // 
            resources.ApplyResources(this.Gvspeed, "Gvspeed");
            this.Gvspeed.BackColor = System.Drawing.Color.Transparent;
            this.Gvspeed.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gvspeed.BaseArcRadius = 60;
            this.Gvspeed.BaseArcStart = 20;
            this.Gvspeed.BaseArcSweep = 320;
            this.Gvspeed.BaseArcWidth = 2;
            this.Gvspeed.Cap_Idx = ((byte)(0));
            this.Gvspeed.CapColor = System.Drawing.Color.White;
            this.Gvspeed.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gvspeed.CapPosition = new System.Drawing.Point(65, 85);
            this.Gvspeed.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(65, 85),
        new System.Drawing.Point(30, 55),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gvspeed.CapsText = new string[] {
        "VSI",
        "",
        "",
        "",
        ""};
            this.Gvspeed.CapText = "VSI";
            this.Gvspeed.Center = new System.Drawing.Point(75, 75);
            this.Gvspeed.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSourceGaugesTab, "verticalspeed", true));
            this.Gvspeed.MaxValue = 10F;
            this.Gvspeed.MinValue = -10F;
            this.Gvspeed.Name = "Gvspeed";
            this.Gvspeed.Need_Idx = ((byte)(3));
            this.Gvspeed.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gvspeed.NeedleColor2 = System.Drawing.Color.White;
            this.Gvspeed.NeedleEnabled = false;
            this.Gvspeed.NeedleRadius = 80;
            this.Gvspeed.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gvspeed.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.Gvspeed.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.Gvspeed.NeedlesRadius = new int[] {
        50,
        30,
        50,
        80};
            this.Gvspeed.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gvspeed.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.Gvspeed.NeedleType = 0;
            this.Gvspeed.NeedleWidth = 2;
            this.Gvspeed.Range_Idx = ((byte)(0));
            this.Gvspeed.RangeColor = System.Drawing.Color.LightGreen;
            this.Gvspeed.RangeEnabled = false;
            this.Gvspeed.RangeEndValue = 360F;
            this.Gvspeed.RangeInnerRadius = 1;
            this.Gvspeed.RangeOuterRadius = 60;
            this.Gvspeed.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gvspeed.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gvspeed.RangesEndValue = new float[] {
        360F,
        200F,
        150F,
        0F,
        0F};
            this.Gvspeed.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gvspeed.RangesOuterRadius = new int[] {
        60,
        60,
        60,
        80,
        80};
            this.Gvspeed.RangesStartValue = new float[] {
        0F,
        150F,
        75F,
        0F,
        0F};
            this.Gvspeed.RangeStartValue = 0F;
            this.Gvspeed.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleLinesInterInnerRadius = 52;
            this.Gvspeed.ScaleLinesInterOuterRadius = 60;
            this.Gvspeed.ScaleLinesInterWidth = 1;
            this.Gvspeed.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleLinesMajorInnerRadius = 50;
            this.Gvspeed.ScaleLinesMajorOuterRadius = 60;
            this.Gvspeed.ScaleLinesMajorStepValue = 2F;
            this.Gvspeed.ScaleLinesMajorWidth = 2;
            this.Gvspeed.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleLinesMinorInnerRadius = 55;
            this.Gvspeed.ScaleLinesMinorNumOf = 9;
            this.Gvspeed.ScaleLinesMinorOuterRadius = 60;
            this.Gvspeed.ScaleLinesMinorWidth = 1;
            this.Gvspeed.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleNumbersFormat = "";
            this.Gvspeed.ScaleNumbersRadius = 42;
            this.Gvspeed.ScaleNumbersRotation = 0;
            this.Gvspeed.ScaleNumbersStartScaleLine = 1;
            this.Gvspeed.ScaleNumbersStepScaleLines = 1;
            this.toolTip1.SetToolTip(this.Gvspeed, resources.GetString("Gvspeed.ToolTip"));
            this.Gvspeed.Value = 0F;
            this.Gvspeed.Value0 = 0F;
            this.Gvspeed.Value1 = 0F;
            this.Gvspeed.Value2 = 0F;
            this.Gvspeed.Value3 = 0F;
            // 
            // bindingSourceGaugesTab
            // 
            this.bindingSourceGaugesTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // Gheading
            // 
            resources.ApplyResources(this.Gheading, "Gheading");
            this.Gheading.BackColor = System.Drawing.Color.Transparent;
            this.Gheading.DataBindings.Add(new System.Windows.Forms.Binding("Heading", this.bindingSourceGaugesTab, "yaw", true));
            this.Gheading.DataBindings.Add(new System.Windows.Forms.Binding("NavHeading", this.bindingSourceGaugesTab, "nav_bearing", true));
            this.Gheading.Heading = 0;
            this.Gheading.Name = "Gheading";
            this.Gheading.NavHeading = 0;
            this.toolTip1.SetToolTip(this.Gheading, resources.GetString("Gheading.ToolTip"));
            // 
            // Galt
            // 
            resources.ApplyResources(this.Galt, "Galt");
            this.Galt.BackColor = System.Drawing.Color.Transparent;
            this.Galt.BaseArcColor = System.Drawing.Color.Transparent;
            this.Galt.BaseArcRadius = 60;
            this.Galt.BaseArcStart = 270;
            this.Galt.BaseArcSweep = 360;
            this.Galt.BaseArcWidth = 2;
            this.Galt.Cap_Idx = ((byte)(0));
            this.Galt.CapColor = System.Drawing.Color.White;
            this.Galt.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Galt.CapPosition = new System.Drawing.Point(68, 85);
            this.Galt.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(68, 85),
        new System.Drawing.Point(30, 55),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Galt.CapsText = new string[] {
        "Alt",
        "",
        "",
        "",
        ""};
            this.Galt.CapText = "Alt";
            this.Galt.Center = new System.Drawing.Point(75, 75);
            this.Galt.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSourceGaugesTab, "altd100", true));
            this.Galt.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.bindingSourceGaugesTab, "altd1000", true));
            this.Galt.DataBindings.Add(new System.Windows.Forms.Binding("Value2", this.bindingSourceGaugesTab, "targetaltd100", true));
            this.Galt.MaxValue = 9.99F;
            this.Galt.MinValue = 0F;
            this.Galt.Name = "Galt";
            this.Galt.Need_Idx = ((byte)(3));
            this.Galt.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Galt.NeedleColor2 = System.Drawing.Color.White;
            this.Galt.NeedleEnabled = false;
            this.Galt.NeedleRadius = 80;
            this.Galt.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Galt.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.Galt.NeedlesEnabled = new bool[] {
        true,
        true,
        true,
        false};
            this.Galt.NeedlesRadius = new int[] {
        50,
        30,
        50,
        80};
            this.Galt.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Galt.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.Galt.NeedleType = 0;
            this.Galt.NeedleWidth = 2;
            this.Galt.Range_Idx = ((byte)(0));
            this.Galt.RangeColor = System.Drawing.Color.LightGreen;
            this.Galt.RangeEnabled = false;
            this.Galt.RangeEndValue = 360F;
            this.Galt.RangeInnerRadius = 1;
            this.Galt.RangeOuterRadius = 60;
            this.Galt.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Galt.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Galt.RangesEndValue = new float[] {
        360F,
        200F,
        150F,
        0F,
        0F};
            this.Galt.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Galt.RangesOuterRadius = new int[] {
        60,
        60,
        60,
        80,
        80};
            this.Galt.RangesStartValue = new float[] {
        0F,
        150F,
        75F,
        0F,
        0F};
            this.Galt.RangeStartValue = 0F;
            this.Galt.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Galt.ScaleLinesInterInnerRadius = 52;
            this.Galt.ScaleLinesInterOuterRadius = 60;
            this.Galt.ScaleLinesInterWidth = 1;
            this.Galt.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Galt.ScaleLinesMajorInnerRadius = 50;
            this.Galt.ScaleLinesMajorOuterRadius = 60;
            this.Galt.ScaleLinesMajorStepValue = 1F;
            this.Galt.ScaleLinesMajorWidth = 2;
            this.Galt.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Galt.ScaleLinesMinorInnerRadius = 55;
            this.Galt.ScaleLinesMinorNumOf = 9;
            this.Galt.ScaleLinesMinorOuterRadius = 60;
            this.Galt.ScaleLinesMinorWidth = 1;
            this.Galt.ScaleNumbersColor = System.Drawing.Color.White;
            this.Galt.ScaleNumbersFormat = "";
            this.Galt.ScaleNumbersRadius = 42;
            this.Galt.ScaleNumbersRotation = 0;
            this.Galt.ScaleNumbersStartScaleLine = 1;
            this.Galt.ScaleNumbersStepScaleLines = 1;
            this.toolTip1.SetToolTip(this.Galt, resources.GetString("Galt.ToolTip"));
            this.Galt.Value = 0F;
            this.Galt.Value0 = 0F;
            this.Galt.Value1 = 0F;
            this.Galt.Value2 = 0F;
            this.Galt.Value3 = 0F;
            // 
            // Gspeed
            // 
            resources.ApplyResources(this.Gspeed, "Gspeed");
            this.Gspeed.BackColor = System.Drawing.Color.Transparent;
            this.Gspeed.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gspeed.BaseArcRadius = 70;
            this.Gspeed.BaseArcStart = 135;
            this.Gspeed.BaseArcSweep = 270;
            this.Gspeed.BaseArcWidth = 2;
            this.Gspeed.Cap_Idx = ((byte)(0));
            this.Gspeed.CapColor = System.Drawing.Color.White;
            this.Gspeed.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gspeed.CapPosition = new System.Drawing.Point(58, 85);
            this.Gspeed.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gspeed.CapsText = new string[] {
        "Speed",
        "",
        "",
        "",
        ""};
            this.Gspeed.CapText = "Speed";
            this.Gspeed.Center = new System.Drawing.Point(75, 75);
            this.Gspeed.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSourceGaugesTab, "airspeed", true));
            this.Gspeed.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.bindingSourceGaugesTab, "groundspeed", true));
            this.Gspeed.MaxValue = 60F;
            this.Gspeed.MinValue = 0F;
            this.Gspeed.Name = "Gspeed";
            this.Gspeed.Need_Idx = ((byte)(3));
            this.Gspeed.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gspeed.NeedleColor2 = System.Drawing.Color.Brown;
            this.Gspeed.NeedleEnabled = false;
            this.Gspeed.NeedleRadius = 70;
            this.Gspeed.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gspeed.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.Gspeed.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.Gspeed.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.Gspeed.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gspeed.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.Gspeed.NeedleType = 0;
            this.Gspeed.NeedleWidth = 2;
            this.Gspeed.Range_Idx = ((byte)(2));
            this.Gspeed.RangeColor = System.Drawing.Color.Orange;
            this.Gspeed.RangeEnabled = false;
            this.Gspeed.RangeEndValue = 50F;
            this.Gspeed.RangeInnerRadius = 1;
            this.Gspeed.RangeOuterRadius = 70;
            this.Gspeed.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gspeed.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gspeed.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.Gspeed.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gspeed.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.Gspeed.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.Gspeed.RangeStartValue = 35F;
            this.Gspeed.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesInterInnerRadius = 52;
            this.Gspeed.ScaleLinesInterOuterRadius = 60;
            this.Gspeed.ScaleLinesInterWidth = 1;
            this.Gspeed.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesMajorInnerRadius = 50;
            this.Gspeed.ScaleLinesMajorOuterRadius = 60;
            this.Gspeed.ScaleLinesMajorStepValue = 10F;
            this.Gspeed.ScaleLinesMajorWidth = 2;
            this.Gspeed.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesMinorInnerRadius = 55;
            this.Gspeed.ScaleLinesMinorNumOf = 9;
            this.Gspeed.ScaleLinesMinorOuterRadius = 60;
            this.Gspeed.ScaleLinesMinorWidth = 1;
            this.Gspeed.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gspeed.ScaleNumbersFormat = null;
            this.Gspeed.ScaleNumbersRadius = 42;
            this.Gspeed.ScaleNumbersRotation = 0;
            this.Gspeed.ScaleNumbersStartScaleLine = 1;
            this.Gspeed.ScaleNumbersStepScaleLines = 1;
            this.toolTip1.SetToolTip(this.Gspeed, resources.GetString("Gspeed.ToolTip"));
            this.Gspeed.Value = 0F;
            this.Gspeed.Value0 = 0F;
            this.Gspeed.Value1 = 0F;
            this.Gspeed.Value2 = 0F;
            this.Gspeed.Value3 = 0F;
            this.Gspeed.DoubleClick += new System.EventHandler(this.Gspeed_DoubleClick);
            // 
            // tabTransponder
            // 
            resources.ApplyResources(this.tabTransponder, "tabTransponder");
            this.tabTransponder.Controls.Add(this.NACp_tb);
            this.tabTransponder.Controls.Add(this.NIC_tb);
            this.tabTransponder.Controls.Add(this.NACp_lbl);
            this.tabTransponder.Controls.Add(this.NIC_lbl);
            this.tabTransponder.Controls.Add(this.Squawk_nud);
            this.tabTransponder.Controls.Add(this.FlightID_tb);
            this.tabTransponder.Controls.Add(this.fault_clb);
            this.tabTransponder.Controls.Add(this.XPDRConnect_btn);
            this.tabTransponder.Controls.Add(this.Squawk_label);
            this.tabTransponder.Controls.Add(this.FlightID_label);
            this.tabTransponder.Controls.Add(this.IDENT_btn);
            this.tabTransponder.Controls.Add(this.ALT_btn);
            this.tabTransponder.Controls.Add(this.STBY_btn);
            this.tabTransponder.Controls.Add(this.ON_btn);
            this.tabTransponder.Controls.Add(this.Mode_clb);
            this.tabTransponder.Name = "tabTransponder";
            this.toolTip1.SetToolTip(this.tabTransponder, resources.GetString("tabTransponder.ToolTip"));
            this.tabTransponder.UseVisualStyleBackColor = true;
            // 
            // NACp_tb
            // 
            resources.ApplyResources(this.NACp_tb, "NACp_tb");
            this.NACp_tb.Name = "NACp_tb";
            this.NACp_tb.ReadOnly = true;
            this.toolTip1.SetToolTip(this.NACp_tb, resources.GetString("NACp_tb.ToolTip"));
            // 
            // NIC_tb
            // 
            resources.ApplyResources(this.NIC_tb, "NIC_tb");
            this.NIC_tb.Name = "NIC_tb";
            this.NIC_tb.ReadOnly = true;
            this.toolTip1.SetToolTip(this.NIC_tb, resources.GetString("NIC_tb.ToolTip"));
            // 
            // NACp_lbl
            // 
            resources.ApplyResources(this.NACp_lbl, "NACp_lbl");
            this.NACp_lbl.Name = "NACp_lbl";
            this.toolTip1.SetToolTip(this.NACp_lbl, resources.GetString("NACp_lbl.ToolTip"));
            // 
            // NIC_lbl
            // 
            resources.ApplyResources(this.NIC_lbl, "NIC_lbl");
            this.NIC_lbl.Name = "NIC_lbl";
            this.toolTip1.SetToolTip(this.NIC_lbl, resources.GetString("NIC_lbl.ToolTip"));
            // 
            // Squawk_nud
            // 
            resources.ApplyResources(this.Squawk_nud, "Squawk_nud");
            this.Squawk_nud.Maximum = new decimal(new int[] {
            7777,
            0,
            0,
            0});
            this.Squawk_nud.Name = "Squawk_nud";
            this.toolTip1.SetToolTip(this.Squawk_nud, resources.GetString("Squawk_nud.ToolTip"));
            this.Squawk_nud.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.Squawk_nud.ValueChanged += new System.EventHandler(this.Squawk_nud_ValueChanged);
            this.Squawk_nud.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Squawk_nud_MouseWheel);
            // 
            // FlightID_tb
            // 
            resources.ApplyResources(this.FlightID_tb, "FlightID_tb");
            this.FlightID_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FlightID_tb.Name = "FlightID_tb";
            this.toolTip1.SetToolTip(this.FlightID_tb, resources.GetString("FlightID_tb.ToolTip"));
            this.FlightID_tb.TextChanged += new System.EventHandler(this.FlightID_tb_TextChanged);
            // 
            // fault_clb
            // 
            resources.ApplyResources(this.fault_clb, "fault_clb");
            this.fault_clb.FormattingEnabled = true;
            this.fault_clb.Items.AddRange(new object[] {
            resources.GetString("fault_clb.Items"),
            resources.GetString("fault_clb.Items1"),
            resources.GetString("fault_clb.Items2"),
            resources.GetString("fault_clb.Items3"),
            resources.GetString("fault_clb.Items4")});
            this.fault_clb.Name = "fault_clb";
            this.toolTip1.SetToolTip(this.fault_clb, resources.GetString("fault_clb.ToolTip"));
            // 
            // XPDRConnect_btn
            // 
            resources.ApplyResources(this.XPDRConnect_btn, "XPDRConnect_btn");
            this.XPDRConnect_btn.Name = "XPDRConnect_btn";
            this.toolTip1.SetToolTip(this.XPDRConnect_btn, resources.GetString("XPDRConnect_btn.ToolTip"));
            this.XPDRConnect_btn.UseVisualStyleBackColor = true;
            this.XPDRConnect_btn.Click += new System.EventHandler(this.XPDRConnect_btn_Click);
            // 
            // Squawk_label
            // 
            resources.ApplyResources(this.Squawk_label, "Squawk_label");
            this.Squawk_label.Name = "Squawk_label";
            this.toolTip1.SetToolTip(this.Squawk_label, resources.GetString("Squawk_label.ToolTip"));
            // 
            // FlightID_label
            // 
            resources.ApplyResources(this.FlightID_label, "FlightID_label");
            this.FlightID_label.Name = "FlightID_label";
            this.toolTip1.SetToolTip(this.FlightID_label, resources.GetString("FlightID_label.ToolTip"));
            // 
            // IDENT_btn
            // 
            resources.ApplyResources(this.IDENT_btn, "IDENT_btn");
            this.IDENT_btn.Name = "IDENT_btn";
            this.toolTip1.SetToolTip(this.IDENT_btn, resources.GetString("IDENT_btn.ToolTip"));
            this.IDENT_btn.UseVisualStyleBackColor = true;
            this.IDENT_btn.Click += new System.EventHandler(this.IDENT_btn_Click);
            // 
            // ALT_btn
            // 
            resources.ApplyResources(this.ALT_btn, "ALT_btn");
            this.ALT_btn.Name = "ALT_btn";
            this.toolTip1.SetToolTip(this.ALT_btn, resources.GetString("ALT_btn.ToolTip"));
            this.ALT_btn.UseVisualStyleBackColor = true;
            this.ALT_btn.Click += new System.EventHandler(this.ALT_btn_Click);
            // 
            // STBY_btn
            // 
            resources.ApplyResources(this.STBY_btn, "STBY_btn");
            this.STBY_btn.Name = "STBY_btn";
            this.toolTip1.SetToolTip(this.STBY_btn, resources.GetString("STBY_btn.ToolTip"));
            this.STBY_btn.UseVisualStyleBackColor = true;
            this.STBY_btn.Click += new System.EventHandler(this.STBY_btn_Click);
            // 
            // ON_btn
            // 
            resources.ApplyResources(this.ON_btn, "ON_btn");
            this.ON_btn.Name = "ON_btn";
            this.toolTip1.SetToolTip(this.ON_btn, resources.GetString("ON_btn.ToolTip"));
            this.ON_btn.UseVisualStyleBackColor = true;
            this.ON_btn.Click += new System.EventHandler(this.ON_btn_Click);
            // 
            // Mode_clb
            // 
            resources.ApplyResources(this.Mode_clb, "Mode_clb");
            this.Mode_clb.CheckOnClick = true;
            this.Mode_clb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Mode_clb.FormattingEnabled = true;
            this.Mode_clb.Items.AddRange(new object[] {
            resources.GetString("Mode_clb.Items"),
            resources.GetString("Mode_clb.Items1"),
            resources.GetString("Mode_clb.Items2"),
            resources.GetString("Mode_clb.Items3")});
            this.Mode_clb.Name = "Mode_clb";
            this.toolTip1.SetToolTip(this.Mode_clb, resources.GetString("Mode_clb.ToolTip"));
            // 
            // tabStatus
            // 
            resources.ApplyResources(this.tabStatus, "tabStatus");
            this.tabStatus.Name = "tabStatus";
            this.toolTip1.SetToolTip(this.tabStatus, resources.GetString("tabStatus.ToolTip"));
            this.tabStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.tabStatus_Paint);
            // 
            // tabServo
            // 
            resources.ApplyResources(this.tabServo, "tabServo");
            this.tabServo.Controls.Add(this.flowLayoutPanelServos);
            this.tabServo.Name = "tabServo";
            this.toolTip1.SetToolTip(this.tabServo, resources.GetString("tabServo.ToolTip"));
            this.tabServo.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelServos
            // 
            resources.ApplyResources(this.flowLayoutPanelServos, "flowLayoutPanelServos");
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions1);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions2);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions3);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions4);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions5);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions6);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions7);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions8);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions9);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions10);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions11);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions12);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions1);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions2);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions3);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions4);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions5);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions6);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions7);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions8);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions9);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions10);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions11);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions12);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions13);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions14);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions15);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions16);
            this.flowLayoutPanelServos.Name = "flowLayoutPanelServos";
            this.toolTip1.SetToolTip(this.flowLayoutPanelServos, resources.GetString("flowLayoutPanelServos.ToolTip"));
            // 
            // servoOptions1
            // 
            resources.ApplyResources(this.servoOptions1, "servoOptions1");
            this.servoOptions1.Name = "servoOptions1";
            this.servoOptions1.thisservo = 5;
            this.toolTip1.SetToolTip(this.servoOptions1, resources.GetString("servoOptions1.ToolTip"));
            // 
            // servoOptions2
            // 
            resources.ApplyResources(this.servoOptions2, "servoOptions2");
            this.servoOptions2.Name = "servoOptions2";
            this.servoOptions2.thisservo = 6;
            this.toolTip1.SetToolTip(this.servoOptions2, resources.GetString("servoOptions2.ToolTip"));
            // 
            // servoOptions3
            // 
            resources.ApplyResources(this.servoOptions3, "servoOptions3");
            this.servoOptions3.Name = "servoOptions3";
            this.servoOptions3.thisservo = 7;
            this.toolTip1.SetToolTip(this.servoOptions3, resources.GetString("servoOptions3.ToolTip"));
            // 
            // servoOptions4
            // 
            resources.ApplyResources(this.servoOptions4, "servoOptions4");
            this.servoOptions4.Name = "servoOptions4";
            this.servoOptions4.thisservo = 8;
            this.toolTip1.SetToolTip(this.servoOptions4, resources.GetString("servoOptions4.ToolTip"));
            // 
            // servoOptions5
            // 
            resources.ApplyResources(this.servoOptions5, "servoOptions5");
            this.servoOptions5.Name = "servoOptions5";
            this.servoOptions5.thisservo = 9;
            this.toolTip1.SetToolTip(this.servoOptions5, resources.GetString("servoOptions5.ToolTip"));
            // 
            // servoOptions6
            // 
            resources.ApplyResources(this.servoOptions6, "servoOptions6");
            this.servoOptions6.Name = "servoOptions6";
            this.servoOptions6.thisservo = 10;
            this.toolTip1.SetToolTip(this.servoOptions6, resources.GetString("servoOptions6.ToolTip"));
            // 
            // servoOptions7
            // 
            resources.ApplyResources(this.servoOptions7, "servoOptions7");
            this.servoOptions7.Name = "servoOptions7";
            this.servoOptions7.thisservo = 11;
            this.toolTip1.SetToolTip(this.servoOptions7, resources.GetString("servoOptions7.ToolTip"));
            // 
            // servoOptions8
            // 
            resources.ApplyResources(this.servoOptions8, "servoOptions8");
            this.servoOptions8.Name = "servoOptions8";
            this.servoOptions8.thisservo = 12;
            this.toolTip1.SetToolTip(this.servoOptions8, resources.GetString("servoOptions8.ToolTip"));
            // 
            // servoOptions9
            // 
            resources.ApplyResources(this.servoOptions9, "servoOptions9");
            this.servoOptions9.Name = "servoOptions9";
            this.servoOptions9.thisservo = 13;
            this.toolTip1.SetToolTip(this.servoOptions9, resources.GetString("servoOptions9.ToolTip"));
            // 
            // servoOptions10
            // 
            resources.ApplyResources(this.servoOptions10, "servoOptions10");
            this.servoOptions10.Name = "servoOptions10";
            this.servoOptions10.thisservo = 14;
            this.toolTip1.SetToolTip(this.servoOptions10, resources.GetString("servoOptions10.ToolTip"));
            // 
            // servoOptions11
            // 
            resources.ApplyResources(this.servoOptions11, "servoOptions11");
            this.servoOptions11.Name = "servoOptions11";
            this.servoOptions11.thisservo = 15;
            this.toolTip1.SetToolTip(this.servoOptions11, resources.GetString("servoOptions11.ToolTip"));
            // 
            // servoOptions12
            // 
            resources.ApplyResources(this.servoOptions12, "servoOptions12");
            this.servoOptions12.Name = "servoOptions12";
            this.servoOptions12.thisservo = 16;
            this.toolTip1.SetToolTip(this.servoOptions12, resources.GetString("servoOptions12.ToolTip"));
            // 
            // relayOptions1
            // 
            resources.ApplyResources(this.relayOptions1, "relayOptions1");
            this.relayOptions1.Name = "relayOptions1";
            this.relayOptions1.thisrelay = 0;
            this.toolTip1.SetToolTip(this.relayOptions1, resources.GetString("relayOptions1.ToolTip"));
            // 
            // relayOptions2
            // 
            resources.ApplyResources(this.relayOptions2, "relayOptions2");
            this.relayOptions2.Name = "relayOptions2";
            this.relayOptions2.thisrelay = 1;
            this.toolTip1.SetToolTip(this.relayOptions2, resources.GetString("relayOptions2.ToolTip"));
            // 
            // relayOptions3
            // 
            resources.ApplyResources(this.relayOptions3, "relayOptions3");
            this.relayOptions3.Name = "relayOptions3";
            this.relayOptions3.thisrelay = 2;
            this.toolTip1.SetToolTip(this.relayOptions3, resources.GetString("relayOptions3.ToolTip"));
            // 
            // relayOptions4
            // 
            resources.ApplyResources(this.relayOptions4, "relayOptions4");
            this.relayOptions4.Name = "relayOptions4";
            this.relayOptions4.thisrelay = 3;
            this.toolTip1.SetToolTip(this.relayOptions4, resources.GetString("relayOptions4.ToolTip"));
            // 
            // relayOptions5
            // 
            resources.ApplyResources(this.relayOptions5, "relayOptions5");
            this.relayOptions5.Name = "relayOptions5";
            this.relayOptions5.thisrelay = 4;
            this.toolTip1.SetToolTip(this.relayOptions5, resources.GetString("relayOptions5.ToolTip"));
            // 
            // relayOptions6
            // 
            resources.ApplyResources(this.relayOptions6, "relayOptions6");
            this.relayOptions6.Name = "relayOptions6";
            this.relayOptions6.thisrelay = 5;
            this.toolTip1.SetToolTip(this.relayOptions6, resources.GetString("relayOptions6.ToolTip"));
            // 
            // relayOptions7
            // 
            resources.ApplyResources(this.relayOptions7, "relayOptions7");
            this.relayOptions7.Name = "relayOptions7";
            this.relayOptions7.thisrelay = 6;
            this.toolTip1.SetToolTip(this.relayOptions7, resources.GetString("relayOptions7.ToolTip"));
            // 
            // relayOptions8
            // 
            resources.ApplyResources(this.relayOptions8, "relayOptions8");
            this.relayOptions8.Name = "relayOptions8";
            this.relayOptions8.thisrelay = 7;
            this.toolTip1.SetToolTip(this.relayOptions8, resources.GetString("relayOptions8.ToolTip"));
            // 
            // relayOptions9
            // 
            resources.ApplyResources(this.relayOptions9, "relayOptions9");
            this.relayOptions9.Name = "relayOptions9";
            this.relayOptions9.thisrelay = 8;
            this.toolTip1.SetToolTip(this.relayOptions9, resources.GetString("relayOptions9.ToolTip"));
            // 
            // relayOptions10
            // 
            resources.ApplyResources(this.relayOptions10, "relayOptions10");
            this.relayOptions10.Name = "relayOptions10";
            this.relayOptions10.thisrelay = 9;
            this.toolTip1.SetToolTip(this.relayOptions10, resources.GetString("relayOptions10.ToolTip"));
            // 
            // relayOptions11
            // 
            resources.ApplyResources(this.relayOptions11, "relayOptions11");
            this.relayOptions11.Name = "relayOptions11";
            this.relayOptions11.thisrelay = 10;
            this.toolTip1.SetToolTip(this.relayOptions11, resources.GetString("relayOptions11.ToolTip"));
            // 
            // relayOptions12
            // 
            resources.ApplyResources(this.relayOptions12, "relayOptions12");
            this.relayOptions12.Name = "relayOptions12";
            this.relayOptions12.thisrelay = 11;
            this.toolTip1.SetToolTip(this.relayOptions12, resources.GetString("relayOptions12.ToolTip"));
            // 
            // relayOptions13
            // 
            resources.ApplyResources(this.relayOptions13, "relayOptions13");
            this.relayOptions13.Name = "relayOptions13";
            this.relayOptions13.thisrelay = 12;
            this.toolTip1.SetToolTip(this.relayOptions13, resources.GetString("relayOptions13.ToolTip"));
            // 
            // relayOptions14
            // 
            resources.ApplyResources(this.relayOptions14, "relayOptions14");
            this.relayOptions14.Name = "relayOptions14";
            this.relayOptions14.thisrelay = 13;
            this.toolTip1.SetToolTip(this.relayOptions14, resources.GetString("relayOptions14.ToolTip"));
            // 
            // relayOptions15
            // 
            resources.ApplyResources(this.relayOptions15, "relayOptions15");
            this.relayOptions15.Name = "relayOptions15";
            this.relayOptions15.thisrelay = 14;
            this.toolTip1.SetToolTip(this.relayOptions15, resources.GetString("relayOptions15.ToolTip"));
            // 
            // relayOptions16
            // 
            resources.ApplyResources(this.relayOptions16, "relayOptions16");
            this.relayOptions16.Name = "relayOptions16";
            this.relayOptions16.thisrelay = 15;
            this.toolTip1.SetToolTip(this.relayOptions16, resources.GetString("relayOptions16.ToolTip"));
            // 
            // tabAuxFunction
            // 
            resources.ApplyResources(this.tabAuxFunction, "tabAuxFunction");
            this.tabAuxFunction.Controls.Add(this.flowLayoutPanel1);
            this.tabAuxFunction.Name = "tabAuxFunction";
            this.toolTip1.SetToolTip(this.tabAuxFunction, resources.GetString("tabAuxFunction.ToolTip"));
            this.tabAuxFunction.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.auxOptions1);
            this.flowLayoutPanel1.Controls.Add(this.auxOptions2);
            this.flowLayoutPanel1.Controls.Add(this.auxOptions3);
            this.flowLayoutPanel1.Controls.Add(this.auxOptions4);
            this.flowLayoutPanel1.Controls.Add(this.auxOptions5);
            this.flowLayoutPanel1.Controls.Add(this.auxOptions6);
            this.flowLayoutPanel1.Controls.Add(this.auxOptions7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.toolTip1.SetToolTip(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
            // 
            // auxOptions1
            // 
            resources.ApplyResources(this.auxOptions1, "auxOptions1");
            this.auxOptions1.Name = "auxOptions1";
            this.toolTip1.SetToolTip(this.auxOptions1, resources.GetString("auxOptions1.ToolTip"));
            // 
            // auxOptions2
            // 
            resources.ApplyResources(this.auxOptions2, "auxOptions2");
            this.auxOptions2.Name = "auxOptions2";
            this.toolTip1.SetToolTip(this.auxOptions2, resources.GetString("auxOptions2.ToolTip"));
            // 
            // auxOptions3
            // 
            resources.ApplyResources(this.auxOptions3, "auxOptions3");
            this.auxOptions3.Name = "auxOptions3";
            this.toolTip1.SetToolTip(this.auxOptions3, resources.GetString("auxOptions3.ToolTip"));
            // 
            // auxOptions4
            // 
            resources.ApplyResources(this.auxOptions4, "auxOptions4");
            this.auxOptions4.Name = "auxOptions4";
            this.toolTip1.SetToolTip(this.auxOptions4, resources.GetString("auxOptions4.ToolTip"));
            // 
            // auxOptions5
            // 
            resources.ApplyResources(this.auxOptions5, "auxOptions5");
            this.auxOptions5.Name = "auxOptions5";
            this.toolTip1.SetToolTip(this.auxOptions5, resources.GetString("auxOptions5.ToolTip"));
            // 
            // auxOptions6
            // 
            resources.ApplyResources(this.auxOptions6, "auxOptions6");
            this.auxOptions6.Name = "auxOptions6";
            this.toolTip1.SetToolTip(this.auxOptions6, resources.GetString("auxOptions6.ToolTip"));
            // 
            // auxOptions7
            // 
            resources.ApplyResources(this.auxOptions7, "auxOptions7");
            this.auxOptions7.Name = "auxOptions7";
            this.toolTip1.SetToolTip(this.auxOptions7, resources.GetString("auxOptions7.ToolTip"));
            // 
            // tabScripts
            // 
            resources.ApplyResources(this.tabScripts, "tabScripts");
            this.tabScripts.Controls.Add(this.checkBoxRedirectOutput);
            this.tabScripts.Controls.Add(this.BUT_edit_selected);
            this.tabScripts.Controls.Add(this.labelSelectedScript);
            this.tabScripts.Controls.Add(this.BUT_run_script);
            this.tabScripts.Controls.Add(this.BUT_abort_script);
            this.tabScripts.Controls.Add(this.labelScriptStatus);
            this.tabScripts.Controls.Add(this.BUT_select_script);
            this.tabScripts.Name = "tabScripts";
            this.toolTip1.SetToolTip(this.tabScripts, resources.GetString("tabScripts.ToolTip"));
            this.tabScripts.UseVisualStyleBackColor = true;
            // 
            // checkBoxRedirectOutput
            // 
            resources.ApplyResources(this.checkBoxRedirectOutput, "checkBoxRedirectOutput");
            this.checkBoxRedirectOutput.Checked = true;
            this.checkBoxRedirectOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRedirectOutput.Name = "checkBoxRedirectOutput";
            this.toolTip1.SetToolTip(this.checkBoxRedirectOutput, resources.GetString("checkBoxRedirectOutput.ToolTip"));
            this.checkBoxRedirectOutput.UseVisualStyleBackColor = true;
            // 
            // BUT_edit_selected
            // 
            resources.ApplyResources(this.BUT_edit_selected, "BUT_edit_selected");
            this.BUT_edit_selected.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_edit_selected.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_edit_selected.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_edit_selected.Name = "BUT_edit_selected";
            this.BUT_edit_selected.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_edit_selected, resources.GetString("BUT_edit_selected.ToolTip"));
            this.BUT_edit_selected.UseVisualStyleBackColor = true;
            this.BUT_edit_selected.Click += new System.EventHandler(this.BUT_edit_selected_Click);
            // 
            // labelSelectedScript
            // 
            resources.ApplyResources(this.labelSelectedScript, "labelSelectedScript");
            this.labelSelectedScript.Name = "labelSelectedScript";
            this.toolTip1.SetToolTip(this.labelSelectedScript, resources.GetString("labelSelectedScript.ToolTip"));
            // 
            // BUT_run_script
            // 
            resources.ApplyResources(this.BUT_run_script, "BUT_run_script");
            this.BUT_run_script.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_run_script.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_run_script.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_run_script.Name = "BUT_run_script";
            this.BUT_run_script.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_run_script, resources.GetString("BUT_run_script.ToolTip"));
            this.BUT_run_script.UseVisualStyleBackColor = true;
            this.BUT_run_script.Click += new System.EventHandler(this.BUT_run_script_Click);
            // 
            // BUT_abort_script
            // 
            resources.ApplyResources(this.BUT_abort_script, "BUT_abort_script");
            this.BUT_abort_script.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_abort_script.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_abort_script.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_abort_script.Name = "BUT_abort_script";
            this.BUT_abort_script.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_abort_script, resources.GetString("BUT_abort_script.ToolTip"));
            this.BUT_abort_script.UseVisualStyleBackColor = true;
            this.BUT_abort_script.Click += new System.EventHandler(this.BUT_abort_script_Click);
            // 
            // labelScriptStatus
            // 
            resources.ApplyResources(this.labelScriptStatus, "labelScriptStatus");
            this.labelScriptStatus.Name = "labelScriptStatus";
            this.toolTip1.SetToolTip(this.labelScriptStatus, resources.GetString("labelScriptStatus.ToolTip"));
            // 
            // BUT_select_script
            // 
            resources.ApplyResources(this.BUT_select_script, "BUT_select_script");
            this.BUT_select_script.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_select_script.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_select_script.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_select_script.Name = "BUT_select_script";
            this.BUT_select_script.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_select_script, resources.GetString("BUT_select_script.ToolTip"));
            this.BUT_select_script.UseVisualStyleBackColor = true;
            this.BUT_select_script.Click += new System.EventHandler(this.BUT_select_script_Click);
            // 
            // tabPayload
            // 
            resources.ApplyResources(this.tabPayload, "tabPayload");
            this.tabPayload.Controls.Add(this.BUT_GimbalVideo);
            this.tabPayload.Controls.Add(this.groupBoxRoll);
            this.tabPayload.Controls.Add(this.groupBoxYaw);
            this.tabPayload.Controls.Add(this.BUT_resetGimbalPos);
            this.tabPayload.Controls.Add(this.groupBoxPitch);
            this.tabPayload.Name = "tabPayload";
            this.toolTip1.SetToolTip(this.tabPayload, resources.GetString("tabPayload.ToolTip"));
            this.tabPayload.UseVisualStyleBackColor = true;
            // 
            // BUT_GimbalVideo
            // 
            resources.ApplyResources(this.BUT_GimbalVideo, "BUT_GimbalVideo");
            this.BUT_GimbalVideo.Name = "BUT_GimbalVideo";
            this.BUT_GimbalVideo.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_GimbalVideo, resources.GetString("BUT_GimbalVideo.ToolTip"));
            this.BUT_GimbalVideo.UseVisualStyleBackColor = true;
            this.BUT_GimbalVideo.Click += new System.EventHandler(this.gimbalVideoPopOutToolStripMenuItem_Click);
            // 
            // groupBoxRoll
            // 
            resources.ApplyResources(this.groupBoxRoll, "groupBoxRoll");
            this.groupBoxRoll.Controls.Add(this.TXT_gimbalRollPos);
            this.groupBoxRoll.Controls.Add(this.trackBarRoll);
            this.groupBoxRoll.Name = "groupBoxRoll";
            this.groupBoxRoll.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBoxRoll, resources.GetString("groupBoxRoll.ToolTip"));
            // 
            // TXT_gimbalRollPos
            // 
            resources.ApplyResources(this.TXT_gimbalRollPos, "TXT_gimbalRollPos");
            this.TXT_gimbalRollPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePayloadTab, "campointb", true));
            this.TXT_gimbalRollPos.Name = "TXT_gimbalRollPos";
            this.toolTip1.SetToolTip(this.TXT_gimbalRollPos, resources.GetString("TXT_gimbalRollPos.ToolTip"));
            // 
            // bindingSourcePayloadTab
            // 
            this.bindingSourcePayloadTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // trackBarRoll
            // 
            resources.ApplyResources(this.trackBarRoll, "trackBarRoll");
            this.trackBarRoll.LargeChange = 10;
            this.trackBarRoll.Maximum = 90;
            this.trackBarRoll.Minimum = -90;
            this.trackBarRoll.Name = "trackBarRoll";
            this.trackBarRoll.TickFrequency = 10;
            this.toolTip1.SetToolTip(this.trackBarRoll, resources.GetString("trackBarRoll.ToolTip"));
            this.trackBarRoll.Scroll += new System.EventHandler(this.gimbalTrackbar_Scroll);
            // 
            // groupBoxYaw
            // 
            resources.ApplyResources(this.groupBoxYaw, "groupBoxYaw");
            this.groupBoxYaw.Controls.Add(this.TXT_gimbalYawPos);
            this.groupBoxYaw.Controls.Add(this.trackBarYaw);
            this.groupBoxYaw.Name = "groupBoxYaw";
            this.groupBoxYaw.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBoxYaw, resources.GetString("groupBoxYaw.ToolTip"));
            // 
            // TXT_gimbalYawPos
            // 
            resources.ApplyResources(this.TXT_gimbalYawPos, "TXT_gimbalYawPos");
            this.TXT_gimbalYawPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePayloadTab, "campointc", true));
            this.TXT_gimbalYawPos.Name = "TXT_gimbalYawPos";
            this.toolTip1.SetToolTip(this.TXT_gimbalYawPos, resources.GetString("TXT_gimbalYawPos.ToolTip"));
            // 
            // trackBarYaw
            // 
            resources.ApplyResources(this.trackBarYaw, "trackBarYaw");
            this.trackBarYaw.LargeChange = 10;
            this.trackBarYaw.Maximum = 180;
            this.trackBarYaw.Minimum = -180;
            this.trackBarYaw.Name = "trackBarYaw";
            this.trackBarYaw.TickFrequency = 10;
            this.toolTip1.SetToolTip(this.trackBarYaw, resources.GetString("trackBarYaw.ToolTip"));
            this.trackBarYaw.Scroll += new System.EventHandler(this.gimbalTrackbar_Scroll);
            // 
            // BUT_resetGimbalPos
            // 
            resources.ApplyResources(this.BUT_resetGimbalPos, "BUT_resetGimbalPos");
            this.BUT_resetGimbalPos.Name = "BUT_resetGimbalPos";
            this.BUT_resetGimbalPos.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_resetGimbalPos, resources.GetString("BUT_resetGimbalPos.ToolTip"));
            this.BUT_resetGimbalPos.UseVisualStyleBackColor = true;
            this.BUT_resetGimbalPos.Click += new System.EventHandler(this.BUT_resetGimbalPos_Click);
            // 
            // groupBoxPitch
            // 
            resources.ApplyResources(this.groupBoxPitch, "groupBoxPitch");
            this.groupBoxPitch.Controls.Add(this.trackBarPitch);
            this.groupBoxPitch.Controls.Add(this.TXT_gimbalPitchPos);
            this.groupBoxPitch.Name = "groupBoxPitch";
            this.groupBoxPitch.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBoxPitch, resources.GetString("groupBoxPitch.ToolTip"));
            // 
            // trackBarPitch
            // 
            resources.ApplyResources(this.trackBarPitch, "trackBarPitch");
            this.trackBarPitch.LargeChange = 10;
            this.trackBarPitch.Maximum = 90;
            this.trackBarPitch.Minimum = -90;
            this.trackBarPitch.Name = "trackBarPitch";
            this.trackBarPitch.SmallChange = 5;
            this.trackBarPitch.TickFrequency = 10;
            this.toolTip1.SetToolTip(this.trackBarPitch, resources.GetString("trackBarPitch.ToolTip"));
            this.trackBarPitch.Scroll += new System.EventHandler(this.gimbalTrackbar_Scroll);
            // 
            // TXT_gimbalPitchPos
            // 
            resources.ApplyResources(this.TXT_gimbalPitchPos, "TXT_gimbalPitchPos");
            this.TXT_gimbalPitchPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePayloadTab, "campointa", true));
            this.TXT_gimbalPitchPos.Name = "TXT_gimbalPitchPos";
            this.toolTip1.SetToolTip(this.TXT_gimbalPitchPos, resources.GetString("TXT_gimbalPitchPos.ToolTip"));
            // 
            // tabTLogs
            // 
            resources.ApplyResources(this.tabTLogs, "tabTLogs");
            this.tabTLogs.Controls.Add(this.tableLayoutPaneltlogs);
            this.tabTLogs.Name = "tabTLogs";
            this.toolTip1.SetToolTip(this.tabTLogs, resources.GetString("tabTLogs.ToolTip"));
            this.tabTLogs.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPaneltlogs
            // 
            resources.ApplyResources(this.tableLayoutPaneltlogs, "tableLayoutPaneltlogs");
            this.tableLayoutPaneltlogs.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_loadtelem, 0, 0);
            this.tableLayoutPaneltlogs.Controls.Add(this.lbl_playbackspeed, 2, 2);
            this.tableLayoutPaneltlogs.Controls.Add(this.lbl_logpercent, 2, 1);
            this.tableLayoutPaneltlogs.Controls.Add(this.LBL_logfn, 1, 0);
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_log2kml, 0, 2);
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_playlog, 0, 1);
            this.tableLayoutPaneltlogs.Controls.Add(this.tracklog, 1, 1);
            this.tableLayoutPaneltlogs.Name = "tableLayoutPaneltlogs";
            this.toolTip1.SetToolTip(this.tableLayoutPaneltlogs, resources.GetString("tableLayoutPaneltlogs.ToolTip"));
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BUT_speed10);
            this.panel2.Controls.Add(this.BUT_speed5);
            this.panel2.Controls.Add(this.BUT_speed2);
            this.panel2.Controls.Add(this.BUT_speed1);
            this.panel2.Controls.Add(this.BUT_speed1_2);
            this.panel2.Controls.Add(this.BUT_speed1_4);
            this.panel2.Controls.Add(this.BUT_speed1_10);
            this.panel2.Name = "panel2";
            this.toolTip1.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // BUT_speed10
            // 
            resources.ApplyResources(this.BUT_speed10, "BUT_speed10");
            this.BUT_speed10.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed10.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed10.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_speed10.Name = "BUT_speed10";
            this.BUT_speed10.Tag = "10";
            this.BUT_speed10.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_speed10, resources.GetString("BUT_speed10.ToolTip"));
            this.BUT_speed10.UseVisualStyleBackColor = true;
            this.BUT_speed10.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed5
            // 
            resources.ApplyResources(this.BUT_speed5, "BUT_speed5");
            this.BUT_speed5.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed5.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed5.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_speed5.Name = "BUT_speed5";
            this.BUT_speed5.Tag = "5";
            this.BUT_speed5.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_speed5, resources.GetString("BUT_speed5.ToolTip"));
            this.BUT_speed5.UseVisualStyleBackColor = true;
            this.BUT_speed5.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed2
            // 
            resources.ApplyResources(this.BUT_speed2, "BUT_speed2");
            this.BUT_speed2.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed2.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed2.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_speed2.Name = "BUT_speed2";
            this.BUT_speed2.Tag = "2";
            this.BUT_speed2.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_speed2, resources.GetString("BUT_speed2.ToolTip"));
            this.BUT_speed2.UseVisualStyleBackColor = true;
            this.BUT_speed2.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1
            // 
            resources.ApplyResources(this.BUT_speed1, "BUT_speed1");
            this.BUT_speed1.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_speed1.Name = "BUT_speed1";
            this.BUT_speed1.Tag = "1";
            this.BUT_speed1.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_speed1, resources.GetString("BUT_speed1.ToolTip"));
            this.BUT_speed1.UseVisualStyleBackColor = true;
            this.BUT_speed1.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1_2
            // 
            resources.ApplyResources(this.BUT_speed1_2, "BUT_speed1_2");
            this.BUT_speed1_2.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1_2.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1_2.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_speed1_2.Name = "BUT_speed1_2";
            this.BUT_speed1_2.Tag = "0.5";
            this.BUT_speed1_2.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_speed1_2, resources.GetString("BUT_speed1_2.ToolTip"));
            this.BUT_speed1_2.UseVisualStyleBackColor = true;
            this.BUT_speed1_2.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1_4
            // 
            resources.ApplyResources(this.BUT_speed1_4, "BUT_speed1_4");
            this.BUT_speed1_4.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1_4.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1_4.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_speed1_4.Name = "BUT_speed1_4";
            this.BUT_speed1_4.Tag = "0.25";
            this.BUT_speed1_4.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_speed1_4, resources.GetString("BUT_speed1_4.ToolTip"));
            this.BUT_speed1_4.UseVisualStyleBackColor = true;
            this.BUT_speed1_4.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1_10
            // 
            resources.ApplyResources(this.BUT_speed1_10, "BUT_speed1_10");
            this.BUT_speed1_10.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1_10.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1_10.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_speed1_10.Name = "BUT_speed1_10";
            this.BUT_speed1_10.Tag = "0.1";
            this.BUT_speed1_10.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_speed1_10, resources.GetString("BUT_speed1_10.ToolTip"));
            this.BUT_speed1_10.UseVisualStyleBackColor = true;
            this.BUT_speed1_10.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_loadtelem
            // 
            resources.ApplyResources(this.BUT_loadtelem, "BUT_loadtelem");
            this.BUT_loadtelem.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_loadtelem.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_loadtelem.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_loadtelem.Name = "BUT_loadtelem";
            this.BUT_loadtelem.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_loadtelem, resources.GetString("BUT_loadtelem.ToolTip"));
            this.BUT_loadtelem.UseVisualStyleBackColor = true;
            this.BUT_loadtelem.Click += new System.EventHandler(this.BUT_loadtelem_Click);
            // 
            // lbl_playbackspeed
            // 
            resources.ApplyResources(this.lbl_playbackspeed, "lbl_playbackspeed");
            this.lbl_playbackspeed.Name = "lbl_playbackspeed";
            this.toolTip1.SetToolTip(this.lbl_playbackspeed, resources.GetString("lbl_playbackspeed.ToolTip"));
            // 
            // lbl_logpercent
            // 
            resources.ApplyResources(this.lbl_logpercent, "lbl_logpercent");
            this.lbl_logpercent.Name = "lbl_logpercent";
            this.toolTip1.SetToolTip(this.lbl_logpercent, resources.GetString("lbl_logpercent.ToolTip"));
            // 
            // LBL_logfn
            // 
            resources.ApplyResources(this.LBL_logfn, "LBL_logfn");
            this.tableLayoutPaneltlogs.SetColumnSpan(this.LBL_logfn, 2);
            this.LBL_logfn.Name = "LBL_logfn";
            this.toolTip1.SetToolTip(this.LBL_logfn, resources.GetString("LBL_logfn.ToolTip"));
            // 
            // BUT_log2kml
            // 
            resources.ApplyResources(this.BUT_log2kml, "BUT_log2kml");
            this.BUT_log2kml.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_log2kml.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_log2kml.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_log2kml.Name = "BUT_log2kml";
            this.BUT_log2kml.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_log2kml, resources.GetString("BUT_log2kml.ToolTip"));
            this.BUT_log2kml.UseVisualStyleBackColor = true;
            this.BUT_log2kml.Click += new System.EventHandler(this.BUT_log2kml_Click);
            // 
            // BUT_playlog
            // 
            resources.ApplyResources(this.BUT_playlog, "BUT_playlog");
            this.BUT_playlog.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_playlog.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_playlog.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_playlog.Name = "BUT_playlog";
            this.BUT_playlog.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_playlog, resources.GetString("BUT_playlog.ToolTip"));
            this.BUT_playlog.UseVisualStyleBackColor = true;
            this.BUT_playlog.Click += new System.EventHandler(this.BUT_playlog_Click);
            // 
            // tracklog
            // 
            resources.ApplyResources(this.tracklog, "tracklog");
            this.tracklog.Maximum = 100;
            this.tracklog.Name = "tracklog";
            this.tracklog.TickFrequency = 5;
            this.toolTip1.SetToolTip(this.tracklog, resources.GetString("tracklog.ToolTip"));
            this.tracklog.Scroll += new System.EventHandler(this.tracklog_Scroll);
            // 
            // tablogbrowse
            // 
            resources.ApplyResources(this.tablogbrowse, "tablogbrowse");
            this.tablogbrowse.Controls.Add(this.tableLayoutPanel2);
            this.tablogbrowse.Name = "tablogbrowse";
            this.toolTip1.SetToolTip(this.tablogbrowse, resources.GetString("tablogbrowse.ToolTip"));
            this.tablogbrowse.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.BUT_DFMavlink, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BUT_georefimage, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BUT_logbrowse, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BUT_matlab, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.but_bintolog, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.but_dflogtokml, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BUT_loganalysis, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.toolTip1.SetToolTip(this.tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
            // 
            // BUT_DFMavlink
            // 
            resources.ApplyResources(this.BUT_DFMavlink, "BUT_DFMavlink");
            this.BUT_DFMavlink.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_DFMavlink.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_DFMavlink.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_DFMavlink.Name = "BUT_DFMavlink";
            this.BUT_DFMavlink.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_DFMavlink, resources.GetString("BUT_DFMavlink.ToolTip"));
            this.BUT_DFMavlink.UseVisualStyleBackColor = true;
            this.BUT_DFMavlink.Click += new System.EventHandler(this.BUT_DFMavlink_Click);
            // 
            // BUT_georefimage
            // 
            resources.ApplyResources(this.BUT_georefimage, "BUT_georefimage");
            this.BUT_georefimage.Name = "BUT_georefimage";
            this.BUT_georefimage.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_georefimage, resources.GetString("BUT_georefimage.ToolTip"));
            this.BUT_georefimage.Click += new System.EventHandler(this.BUT_georefimage_Click);
            // 
            // BUT_logbrowse
            // 
            resources.ApplyResources(this.BUT_logbrowse, "BUT_logbrowse");
            this.BUT_logbrowse.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_logbrowse.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_logbrowse.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_logbrowse.Name = "BUT_logbrowse";
            this.BUT_logbrowse.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_logbrowse, resources.GetString("BUT_logbrowse.ToolTip"));
            this.BUT_logbrowse.UseVisualStyleBackColor = true;
            this.BUT_logbrowse.Click += new System.EventHandler(this.BUT_logbrowse_Click);
            // 
            // BUT_matlab
            // 
            resources.ApplyResources(this.BUT_matlab, "BUT_matlab");
            this.BUT_matlab.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_matlab.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_matlab.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_matlab.Name = "BUT_matlab";
            this.BUT_matlab.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_matlab, resources.GetString("BUT_matlab.ToolTip"));
            this.BUT_matlab.UseVisualStyleBackColor = true;
            this.BUT_matlab.Click += new System.EventHandler(this.BUT_matlab_Click);
            // 
            // but_bintolog
            // 
            resources.ApplyResources(this.but_bintolog, "but_bintolog");
            this.but_bintolog.ColorMouseDown = System.Drawing.Color.Empty;
            this.but_bintolog.ColorMouseOver = System.Drawing.Color.Empty;
            this.but_bintolog.ColorNotEnabled = System.Drawing.Color.Empty;
            this.but_bintolog.Name = "but_bintolog";
            this.but_bintolog.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.but_bintolog, resources.GetString("but_bintolog.ToolTip"));
            this.but_bintolog.UseVisualStyleBackColor = true;
            this.but_bintolog.Click += new System.EventHandler(this.but_bintolog_Click);
            // 
            // but_dflogtokml
            // 
            resources.ApplyResources(this.but_dflogtokml, "but_dflogtokml");
            this.but_dflogtokml.ColorMouseDown = System.Drawing.Color.Empty;
            this.but_dflogtokml.ColorMouseOver = System.Drawing.Color.Empty;
            this.but_dflogtokml.ColorNotEnabled = System.Drawing.Color.Empty;
            this.but_dflogtokml.Name = "but_dflogtokml";
            this.but_dflogtokml.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.but_dflogtokml, resources.GetString("but_dflogtokml.ToolTip"));
            this.but_dflogtokml.UseVisualStyleBackColor = true;
            this.but_dflogtokml.Click += new System.EventHandler(this.but_dflogtokml_Click);
            // 
            // BUT_loganalysis
            // 
            resources.ApplyResources(this.BUT_loganalysis, "BUT_loganalysis");
            this.BUT_loganalysis.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_loganalysis.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_loganalysis.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_loganalysis.Name = "BUT_loganalysis";
            this.BUT_loganalysis.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.BUT_loganalysis, resources.GetString("BUT_loganalysis.ToolTip"));
            this.BUT_loganalysis.UseVisualStyleBackColor = true;
            this.BUT_loganalysis.Click += new System.EventHandler(this.BUT_loganalysis_Click);
            // 
            // panel_persistent
            // 
            resources.ApplyResources(this.panel_persistent, "panel_persistent");
            this.panel_persistent.Name = "panel_persistent";
            this.toolTip1.SetToolTip(this.panel_persistent, resources.GetString("panel_persistent.ToolTip"));
            // 
            // tableMap
            // 
            resources.ApplyResources(this.tableMap, "tableMap");
            this.tableMap.Controls.Add(this.splitContainer1, 0, 0);
            this.tableMap.Controls.Add(this.panel1, 0, 1);
            this.tableMap.Name = "tableMap";
            this.toolTip1.SetToolTip(this.tableMap, resources.GetString("tableMap.ToolTip"));
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.zg1);
            this.toolTip1.SetToolTip(this.splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.ToolTip"));
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.ContextMenuStrip = this.contextMenuStripMap;
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.but_disablejoystick);
            this.splitContainer1.Panel2.Controls.Add(this.Zoomlevel);
            this.splitContainer1.Panel2.Controls.Add(this.distanceBar1);
            this.splitContainer1.Panel2.Controls.Add(this.TRK_zoom);
            this.splitContainer1.Panel2.Controls.Add(this.windDir1);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_hdop);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_sats);
            this.splitContainer1.Panel2.Controls.Add(this.gMapControl1);
            this.toolTip1.SetToolTip(this.splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.ToolTip"));
            this.splitContainer1.Panel2.Resize += new System.EventHandler(this.splitContainer1_Panel2_Resize);
            this.toolTip1.SetToolTip(this.splitContainer1, resources.GetString("splitContainer1.ToolTip"));
            // 
            // zg1
            // 
            resources.ApplyResources(this.zg1, "zg1");
            this.zg1.Name = "zg1";
            this.zg1.ScrollGrace = 0D;
            this.zg1.ScrollMaxX = 0D;
            this.zg1.ScrollMaxY = 0D;
            this.zg1.ScrollMaxY2 = 0D;
            this.zg1.ScrollMinX = 0D;
            this.zg1.ScrollMinY = 0D;
            this.zg1.ScrollMinY2 = 0D;
            this.toolTip1.SetToolTip(this.zg1, resources.GetString("zg1.ToolTip"));
            this.zg1.DoubleClick += new System.EventHandler(this.zg1_DoubleClick);
            // 
            // contextMenuStripMap
            // 
            resources.ApplyResources(this.contextMenuStripMap, "contextMenuStripMap");
            this.contextMenuStripMap.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goHereToolStripMenuItem,
            this.flyToHereAltToolStripMenuItem,
            this.flyToCoordsToolStripMenuItem,
            this.addPoiToolStripMenuItem,
            this.pointCameraHereToolStripMenuItem,
            this.PointCameraCoordsToolStripMenuItem1,
            this.triggerCameraToolStripMenuItem,
            this.flightPlannerToolStripMenuItem,
            this.setHomeHereToolStripMenuItem,
            this.takeOffToolStripMenuItem,
            this.onOffCameraOverlapToolStripMenuItem,
            this.jumpToTagToolStripMenuItem,
            this.gimbalVideoToolStripMenuItem});
            this.contextMenuStripMap.Name = "contextMenuStrip1";
            this.toolTip1.SetToolTip(this.contextMenuStripMap, resources.GetString("contextMenuStripMap.ToolTip"));
            // 
            // goHereToolStripMenuItem
            // 
            resources.ApplyResources(this.goHereToolStripMenuItem, "goHereToolStripMenuItem");
            this.goHereToolStripMenuItem.Name = "goHereToolStripMenuItem";
            this.goHereToolStripMenuItem.Click += new System.EventHandler(this.goHereToolStripMenuItem_Click);
            // 
            // flyToHereAltToolStripMenuItem
            // 
            resources.ApplyResources(this.flyToHereAltToolStripMenuItem, "flyToHereAltToolStripMenuItem");
            this.flyToHereAltToolStripMenuItem.Name = "flyToHereAltToolStripMenuItem";
            this.flyToHereAltToolStripMenuItem.Click += new System.EventHandler(this.flyToHereAltToolStripMenuItem_Click);
            // 
            // flyToCoordsToolStripMenuItem
            // 
            resources.ApplyResources(this.flyToCoordsToolStripMenuItem, "flyToCoordsToolStripMenuItem");
            this.flyToCoordsToolStripMenuItem.Name = "flyToCoordsToolStripMenuItem";
            this.flyToCoordsToolStripMenuItem.Click += new System.EventHandler(this.flyToCoordsToolStripMenuItem_Click);
            // 
            // addPoiToolStripMenuItem
            // 
            resources.ApplyResources(this.addPoiToolStripMenuItem, "addPoiToolStripMenuItem");
            this.addPoiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.loadFileToolStripMenuItem,
            this.poiatcoordsToolStripMenuItem});
            this.addPoiToolStripMenuItem.Name = "addPoiToolStripMenuItem";
            this.addPoiToolStripMenuItem.Click += new System.EventHandler(this.addPoiToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            resources.ApplyResources(this.saveFileToolStripMenuItem, "saveFileToolStripMenuItem");
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // loadFileToolStripMenuItem
            // 
            resources.ApplyResources(this.loadFileToolStripMenuItem, "loadFileToolStripMenuItem");
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // poiatcoordsToolStripMenuItem
            // 
            resources.ApplyResources(this.poiatcoordsToolStripMenuItem, "poiatcoordsToolStripMenuItem");
            this.poiatcoordsToolStripMenuItem.Name = "poiatcoordsToolStripMenuItem";
            this.poiatcoordsToolStripMenuItem.Click += new System.EventHandler(this.poiatcoordsToolStripMenuItem_Click);
            // 
            // pointCameraHereToolStripMenuItem
            // 
            resources.ApplyResources(this.pointCameraHereToolStripMenuItem, "pointCameraHereToolStripMenuItem");
            this.pointCameraHereToolStripMenuItem.Name = "pointCameraHereToolStripMenuItem";
            this.pointCameraHereToolStripMenuItem.Click += new System.EventHandler(this.pointCameraHereToolStripMenuItem_Click);
            // 
            // PointCameraCoordsToolStripMenuItem1
            // 
            resources.ApplyResources(this.PointCameraCoordsToolStripMenuItem1, "PointCameraCoordsToolStripMenuItem1");
            this.PointCameraCoordsToolStripMenuItem1.Name = "PointCameraCoordsToolStripMenuItem1";
            this.PointCameraCoordsToolStripMenuItem1.Click += new System.EventHandler(this.PointCameraCoordsToolStripMenuItem1_Click);
            // 
            // triggerCameraToolStripMenuItem
            // 
            resources.ApplyResources(this.triggerCameraToolStripMenuItem, "triggerCameraToolStripMenuItem");
            this.triggerCameraToolStripMenuItem.Name = "triggerCameraToolStripMenuItem";
            this.triggerCameraToolStripMenuItem.Click += new System.EventHandler(this.triggerCameraToolStripMenuItem_Click);
            // 
            // flightPlannerToolStripMenuItem
            // 
            resources.ApplyResources(this.flightPlannerToolStripMenuItem, "flightPlannerToolStripMenuItem");
            this.flightPlannerToolStripMenuItem.Name = "flightPlannerToolStripMenuItem";
            this.flightPlannerToolStripMenuItem.Click += new System.EventHandler(this.flightPlannerToolStripMenuItem_Click);
            // 
            // setHomeHereToolStripMenuItem
            // 
            resources.ApplyResources(this.setHomeHereToolStripMenuItem, "setHomeHereToolStripMenuItem");
            this.setHomeHereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setEKFHomeHereToolStripMenuItem,
            this.setHomeHereToolStripMenuItem1});
            this.setHomeHereToolStripMenuItem.Name = "setHomeHereToolStripMenuItem";
            // 
            // setEKFHomeHereToolStripMenuItem
            // 
            resources.ApplyResources(this.setEKFHomeHereToolStripMenuItem, "setEKFHomeHereToolStripMenuItem");
            this.setEKFHomeHereToolStripMenuItem.Name = "setEKFHomeHereToolStripMenuItem";
            this.setEKFHomeHereToolStripMenuItem.Click += new System.EventHandler(this.setEKFHomeHereToolStripMenuItem_Click);
            // 
            // setHomeHereToolStripMenuItem1
            // 
            resources.ApplyResources(this.setHomeHereToolStripMenuItem1, "setHomeHereToolStripMenuItem1");
            this.setHomeHereToolStripMenuItem1.Name = "setHomeHereToolStripMenuItem1";
            this.setHomeHereToolStripMenuItem1.Click += new System.EventHandler(this.setHomeHereToolStripMenuItem_Click);
            // 
            // takeOffToolStripMenuItem
            // 
            resources.ApplyResources(this.takeOffToolStripMenuItem, "takeOffToolStripMenuItem");
            this.takeOffToolStripMenuItem.Name = "takeOffToolStripMenuItem";
            this.takeOffToolStripMenuItem.Click += new System.EventHandler(this.takeOffToolStripMenuItem_Click);
            // 
            // onOffCameraOverlapToolStripMenuItem
            // 
            resources.ApplyResources(this.onOffCameraOverlapToolStripMenuItem, "onOffCameraOverlapToolStripMenuItem");
            this.onOffCameraOverlapToolStripMenuItem.CheckOnClick = true;
            this.onOffCameraOverlapToolStripMenuItem.Name = "onOffCameraOverlapToolStripMenuItem";
            this.onOffCameraOverlapToolStripMenuItem.Click += new System.EventHandler(this.onOffCameraOverlapToolStripMenuItem_Click);
            // 
            // jumpToTagToolStripMenuItem
            // 
            resources.ApplyResources(this.jumpToTagToolStripMenuItem, "jumpToTagToolStripMenuItem");
            this.jumpToTagToolStripMenuItem.Name = "jumpToTagToolStripMenuItem";
            this.jumpToTagToolStripMenuItem.Click += new System.EventHandler(this.jumpToTagToolStripMenuItem_Click);
            // 
            // gimbalVideoToolStripMenuItem
            // 
            resources.ApplyResources(this.gimbalVideoToolStripMenuItem, "gimbalVideoToolStripMenuItem");
            this.gimbalVideoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gimbalVideoFullSizedToolStripMenuItem,
            this.gimbalVideoMiniToolStripMenuItem,
            this.gimbalVideoPopOutToolStripMenuItem});
            this.gimbalVideoToolStripMenuItem.Name = "gimbalVideoToolStripMenuItem";
            // 
            // gimbalVideoFullSizedToolStripMenuItem
            // 
            resources.ApplyResources(this.gimbalVideoFullSizedToolStripMenuItem, "gimbalVideoFullSizedToolStripMenuItem");
            this.gimbalVideoFullSizedToolStripMenuItem.Name = "gimbalVideoFullSizedToolStripMenuItem";
            this.gimbalVideoFullSizedToolStripMenuItem.Click += new System.EventHandler(this.gimbalVideoFullSizedToolStripMenuItem_Click);
            // 
            // gimbalVideoMiniToolStripMenuItem
            // 
            resources.ApplyResources(this.gimbalVideoMiniToolStripMenuItem, "gimbalVideoMiniToolStripMenuItem");
            this.gimbalVideoMiniToolStripMenuItem.Name = "gimbalVideoMiniToolStripMenuItem";
            this.gimbalVideoMiniToolStripMenuItem.Click += new System.EventHandler(this.gimbalVideoMiniToolStripMenuItem_Click);
            // 
            // gimbalVideoPopOutToolStripMenuItem
            // 
            resources.ApplyResources(this.gimbalVideoPopOutToolStripMenuItem, "gimbalVideoPopOutToolStripMenuItem");
            this.gimbalVideoPopOutToolStripMenuItem.Name = "gimbalVideoPopOutToolStripMenuItem";
            this.gimbalVideoPopOutToolStripMenuItem.Click += new System.EventHandler(this.gimbalVideoPopOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // but_disablejoystick
            // 
            resources.ApplyResources(this.but_disablejoystick, "but_disablejoystick");
            this.but_disablejoystick.ColorMouseDown = System.Drawing.Color.Empty;
            this.but_disablejoystick.ColorMouseOver = System.Drawing.Color.Empty;
            this.but_disablejoystick.ColorNotEnabled = System.Drawing.Color.Empty;
            this.but_disablejoystick.Name = "but_disablejoystick";
            this.but_disablejoystick.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.toolTip1.SetToolTip(this.but_disablejoystick, resources.GetString("but_disablejoystick.ToolTip"));
            this.but_disablejoystick.UseVisualStyleBackColor = true;
            this.but_disablejoystick.Click += new System.EventHandler(this.but_disablejoystick_Click);
            // 
            // Zoomlevel
            // 
            resources.ApplyResources(this.Zoomlevel, "Zoomlevel");
            this.Zoomlevel.DecimalPlaces = 1;
            this.Zoomlevel.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Zoomlevel.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Zoomlevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Zoomlevel.Name = "Zoomlevel";
            this.toolTip1.SetToolTip(this.Zoomlevel, resources.GetString("Zoomlevel.ToolTip"));
            this.Zoomlevel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Zoomlevel.ValueChanged += new System.EventHandler(this.Zoomlevel_ValueChanged);
            // 
            // distanceBar1
            // 
            resources.ApplyResources(this.distanceBar1, "distanceBar1");
            this.distanceBar1.BackColor = System.Drawing.Color.Transparent;
            this.distanceBar1.Name = "distanceBar1";
            this.toolTip1.SetToolTip(this.distanceBar1, resources.GetString("distanceBar1.ToolTip"));
            this.distanceBar1.totaldist = 100F;
            this.distanceBar1.traveleddist = 0F;
            // 
            // TRK_zoom
            // 
            resources.ApplyResources(this.TRK_zoom, "TRK_zoom");
            this.TRK_zoom.LargeChange = 1F;
            this.TRK_zoom.Maximum = 24F;
            this.TRK_zoom.Minimum = 1F;
            this.TRK_zoom.Name = "TRK_zoom";
            this.TRK_zoom.SmallChange = 1F;
            this.TRK_zoom.TickFrequency = 1F;
            this.TRK_zoom.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.toolTip1.SetToolTip(this.TRK_zoom, resources.GetString("TRK_zoom.ToolTip"));
            this.TRK_zoom.Value = 1F;
            this.TRK_zoom.Scroll += new System.EventHandler(this.TRK_zoom_Scroll);
            // 
            // windDir1
            // 
            resources.ApplyResources(this.windDir1, "windDir1");
            this.windDir1.BackColor = System.Drawing.Color.Transparent;
            this.windDir1.DataBindings.Add(new System.Windows.Forms.Binding("Direction", this.bindingSource1, "wind_dir", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.windDir1.DataBindings.Add(new System.Windows.Forms.Binding("Speed", this.bindingSource1, "wind_vel", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.windDir1.Direction = 360D;
            this.windDir1.Name = "windDir1";
            this.windDir1.Speed = 0D;
            this.toolTip1.SetToolTip(this.windDir1, resources.GetString("windDir1.ToolTip"));
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            this.label6.Tag = "custom";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Name = "label5";
            this.label5.Tag = "custom";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Name = "label3";
            this.label3.Tag = "custom";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Name = "label4";
            this.label4.Tag = "custom";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // lbl_hdop
            // 
            resources.ApplyResources(this.lbl_hdop, "lbl_hdop");
            this.lbl_hdop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "gpshdop", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "hdop: 0.0"));
            this.lbl_hdop.Name = "lbl_hdop";
            this.lbl_hdop.resize = true;
            this.toolTip1.SetToolTip(this.lbl_hdop, resources.GetString("lbl_hdop.ToolTip"));
            // 
            // lbl_sats
            // 
            resources.ApplyResources(this.lbl_sats, "lbl_sats");
            this.lbl_sats.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "satcount", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "Sats: 0"));
            this.lbl_sats.Name = "lbl_sats";
            this.lbl_sats.resize = true;
            this.toolTip1.SetToolTip(this.lbl_sats, resources.GetString("lbl_sats.ToolTip"));
            // 
            // gMapControl1
            // 
            resources.ApplyResources(this.gMapControl1, "gMapControl1");
            this.gMapControl1.BackColor = System.Drawing.Color.Black;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.ContextMenuStrip = this.contextMenuStripMap;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Gray;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.HoldInvalidation = false;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 24;
            this.gMapControl1.MinZoom = 0;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.toolTip1.SetToolTip(this.gMapControl1, resources.GetString("gMapControl1.ToolTip"));
            this.gMapControl1.Zoom = 3D;
            this.gMapControl1.OnPositionChanged += new GMap.NET.PositionChanged(this.gMapControl1_OnPositionChanged);
            this.gMapControl1.Click += new System.EventHandler(this.gMapControl1_Click);
            this.gMapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDown);
            this.gMapControl1.MouseLeave += new System.EventHandler(this.gMapControl1_MouseLeave);
            this.gMapControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseMove);
            this.gMapControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseUp);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.coords1);
            this.panel1.Controls.Add(this.CHK_autopan);
            this.panel1.Controls.Add(this.CB_tuning);
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // coords1
            // 
            resources.ApplyResources(this.coords1, "coords1");
            this.coords1.Alt = 0D;
            this.coords1.AltSource = "";
            this.coords1.AltUnit = "m";
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Alt", this.bindingSource1, "alt", true));
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Lat", this.bindingSource1, "lat", true));
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Lng", this.bindingSource1, "lng", true));
            this.coords1.Lat = 0D;
            this.coords1.Lng = 0D;
            this.coords1.Name = "coords1";
            this.toolTip1.SetToolTip(this.coords1, resources.GetString("coords1.ToolTip"));
            this.coords1.Vertical = false;
            // 
            // CHK_autopan
            // 
            resources.ApplyResources(this.CHK_autopan, "CHK_autopan");
            this.CHK_autopan.Checked = true;
            this.CHK_autopan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_autopan.Name = "CHK_autopan";
            this.toolTip1.SetToolTip(this.CHK_autopan, resources.GetString("CHK_autopan.ToolTip"));
            this.CHK_autopan.UseVisualStyleBackColor = true;
            this.CHK_autopan.CheckedChanged += new System.EventHandler(this.CHK_autopan_CheckedChanged);
            // 
            // CB_tuning
            // 
            resources.ApplyResources(this.CB_tuning, "CB_tuning");
            this.CB_tuning.Name = "CB_tuning";
            this.toolTip1.SetToolTip(this.CB_tuning, resources.GetString("CB_tuning.ToolTip"));
            this.CB_tuning.UseVisualStyleBackColor = true;
            this.CB_tuning.CheckedChanged += new System.EventHandler(this.CB_tuning_CheckedChanged);
            // 
            // ZedGraphTimer
            // 
            this.ZedGraphTimer.Tick += new System.EventHandler(this.ZedGraphTimer_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(150)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            // 
            // openScriptDialog
            // 
            resources.ApplyResources(this.openScriptDialog, "openScriptDialog");
            // 
            // scriptChecker
            // 
            this.scriptChecker.Tick += new System.EventHandler(this.scriptChecker_Tick);
            // 
            // Messagetabtimer
            // 
            this.Messagetabtimer.Interval = 200;
            this.Messagetabtimer.Tick += new System.EventHandler(this.Messagetabtimer_Tick);
            // 
            // bindingSourceStatusTab
            // 
            this.bindingSourceStatusTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // FlightData
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.MainH);
            this.Name = "FlightData";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightData_FormClosing);
            this.Load += new System.EventHandler(this.FlightData_Load);
            this.Resize += new System.EventHandler(this.FlightData_Resize);
            this.ParentChanged += new System.EventHandler(this.FlightData_ParentChanged);
            this.MainH.Panel1.ResumeLayout(false);
            this.MainH.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainH)).EndInit();
            this.MainH.ResumeLayout(false);
            this.SubMainLeft.Panel1.ResumeLayout(false);
            this.SubMainLeft.Panel2.ResumeLayout(false);
            this.SubMainLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubMainLeft)).EndInit();
            this.SubMainLeft.ResumeLayout(false);
            this.contextMenuStripHud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).EndInit();
            this.contextMenuStripactionstab.ResumeLayout(false);
            this.tabControlactions.ResumeLayout(false);
            this.tabQuick.ResumeLayout(false);
            this.tableLayoutPanelQuick.ResumeLayout(false);
            this.contextMenuStripQuickView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuickTab)).EndInit();
            this.tabActions.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPagemessages.ResumeLayout(false);
            this.tabPagemessages.PerformLayout();
            this.tabActionsSimple.ResumeLayout(false);
            this.tabPagePreFlight.ResumeLayout(false);
            this.tabGauges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGaugesTab)).EndInit();
            this.tabTransponder.ResumeLayout(false);
            this.tabTransponder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Squawk_nud)).EndInit();
            this.tabServo.ResumeLayout(false);
            this.flowLayoutPanelServos.ResumeLayout(false);
            this.tabAuxFunction.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabScripts.ResumeLayout(false);
            this.tabScripts.PerformLayout();
            this.tabPayload.ResumeLayout(false);
            this.groupBoxRoll.ResumeLayout(false);
            this.groupBoxRoll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePayloadTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoll)).EndInit();
            this.groupBoxYaw.ResumeLayout(false);
            this.groupBoxYaw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYaw)).EndInit();
            this.groupBoxPitch.ResumeLayout(false);
            this.groupBoxPitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).EndInit();
            this.tabTLogs.ResumeLayout(false);
            this.tableLayoutPaneltlogs.ResumeLayout(false);
            this.tableLayoutPaneltlogs.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).EndInit();
            this.tablogbrowse.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableMap.ResumeLayout(false);
            this.tableMap.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatusTab)).EndInit();
            this.ResumeLayout(false);

        }

  

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer ZedGraphTimer;
        private System.Windows.Forms.SplitContainer MainH;
        private System.Windows.Forms.SplitContainer SubMainLeft;
        private System.Windows.Forms.ToolStripMenuItem goHereToolStripMenuItem;
        private Controls.HUD hud1;
        private Controls.MyButton BUT_clear_track;
        private System.Windows.Forms.CheckBox CB_tuning;
        private Controls.MyButton BUT_RAWSensor;
        private Controls.MyButton BUTactiondo;
        private Controls.MyButton BUTrestartmission;
        private System.Windows.Forms.ComboBox CMB_action;
        private Controls.MyButton BUT_Homealt;
        private System.Windows.Forms.TrackBar tracklog;
        private Controls.MyButton BUT_playlog;
        private Controls.MyButton BUT_loadtelem;
        private AGaugeApp.AGauge Galt;
        private AGaugeApp.AGauge Gspeed;
        private AGaugeApp.AGauge Gvspeed;
        private System.Windows.Forms.TableLayoutPanel tableMap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Zoomlevel;
        private Label label1;
        private System.Windows.Forms.CheckBox CHK_autopan;
        public Controls.myGMAP gMapControl1;
        private ZedGraph.ZedGraphControl zg1;
        public System.Windows.Forms.TabControl tabControlactions;
        public System.Windows.Forms.TabPage tabGauges;
        public System.Windows.Forms.TabPage tabStatus;
        public System.Windows.Forms.TabPage tabActions;
        public System.Windows.Forms.TabPage tabTLogs;
        private System.Windows.Forms.ComboBox CMB_modes;
        private Controls.MyButton BUT_setmode;
        private System.Windows.Forms.ComboBox CMB_setwp;
        private Controls.MyButton BUT_setwp;
        private Controls.MyButton BUT_quickmanual;
        private Controls.MyButton BUT_quickrtl;
        private Controls.MyButton BUT_quickauto;
        private Controls.MyButton BUT_log2kml;
        private Controls.MyButton BUT_joystick;
        private System.Windows.Forms.ToolTip toolTip1;
        private Label lbl_logpercent;
        private System.Windows.Forms.ToolStripMenuItem pointCameraHereToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.MyLabel lbl_hdop;
        private Controls.MyLabel lbl_sats;
        private Controls.HSI Gheading;
        private Label lbl_playbackspeed;
        private System.Windows.Forms.ToolStripMenuItem setAspectRatioToolStripMenuItem;
        public System.Windows.Forms.TabPage tabQuick;
        private Controls.QuickView quickView3;
        private Controls.QuickView quickView2;
        private Controls.QuickView quickView1;
        private Controls.QuickView quickView4;
        private System.Windows.Forms.ToolStripMenuItem flyToHereAltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightPlannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userItemsToolStripMenuItem;
        //private Crom.Controls.Docking.DockContainer dockContainer1;
        private Controls.MyButton BUT_ARM;
        private Controls.ModifyandSet modifyandSetAlt;
        private Controls.ModifyandSet modifyandSetSpeed;
        private System.Windows.Forms.ToolStripMenuItem triggerCameraToolStripMenuItem;
        private Controls.MyTrackBar TRK_zoom;
        private Label LBL_logfn;
        public System.Windows.Forms.TabPage tabServo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelServos;
        private Controls.ServoOptions servoOptions1;
        private Controls.ServoOptions servoOptions2;
        private Controls.ServoOptions servoOptions3;
        private Controls.ServoOptions servoOptions4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPaneltlogs;
        private Controls.ServoOptions servoOptions5;
        private Controls.ServoOptions servoOptions6;
        private Controls.ServoOptions servoOptions7;
        private Controls.ServoOptions servoOptions8;
        private Controls.ServoOptions servoOptions9;
        private Controls.ServoOptions servoOptions10;
        private Controls.ServoOptions servoOptions11;
        private Controls.ServoOptions servoOptions12;
        private System.Windows.Forms.BindingSource bindingSourceHud;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQuick;
        private System.Windows.Forms.Panel panel2;
        private Controls.MyButton BUT_speed10;
        private Controls.MyButton BUT_speed5;
        private Controls.MyButton BUT_speed2;
        private Controls.MyButton BUT_speed1;
        private Controls.MyButton BUT_speed1_2;
        private Controls.MyButton BUT_speed1_4;
        private Controls.MyButton BUT_speed1_10;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabPage tablogbrowse;
        private Controls.MyButton BUT_logbrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TabPage tabScripts;
        private Controls.MyButton BUT_edit_selected;
        private System.Windows.Forms.Label labelSelectedScript;
        private Controls.MyButton BUT_run_script;
        private Controls.MyButton BUT_abort_script;
        private System.Windows.Forms.Label labelScriptStatus;
        private Controls.MyButton BUT_select_script;
        private System.Windows.Forms.OpenFileDialog openScriptDialog;
        private System.Windows.Forms.Timer scriptChecker;
        private System.Windows.Forms.CheckBox checkBoxRedirectOutput;
        private System.Windows.Forms.ToolStripMenuItem russianHudToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripMap;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripHud;
        private System.Windows.Forms.BindingSource bindingSourceQuickTab;
        private System.Windows.Forms.BindingSource bindingSourceStatusTab;
        private System.Windows.Forms.BindingSource bindingSourceGaugesTab;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem;
        private MissionPlanner.Controls.Coords coords1;
        private Controls.MyButton BUT_matlab;
        private System.Windows.Forms.ComboBox CMB_mountmode;
        private Controls.MyButton BUT_mountmode;
        public Controls.WindDir windDir1;
        private Controls.MyButton but_bintolog;
        private Controls.MyButton but_dflogtokml;
        private Controls.MyButton BUT_DFMavlink;
        public System.Windows.Forms.TabPage tabPagemessages;
        private System.Windows.Forms.TextBox txt_messagebox;
        private System.Windows.Forms.Timer Messagetabtimer;
        public System.Windows.Forms.TabPage tabActionsSimple;
        private Controls.MyButton myButton1;
        private Controls.MyButton myButton2;
        private Controls.MyButton myButton3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripactionstab;
        private Controls.MyButton BUT_loganalysis;
        private System.Windows.Forms.ToolStripMenuItem addPoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private Controls.DistanceBar distanceBar1;
        private System.Windows.Forms.ToolStripMenuItem takeOffToolStripMenuItem;
        private Controls.MyButton BUT_resumemis;
        public System.Windows.Forms.TabPage tabPagePreFlight;
        private Controls.PreFlight.CheckListControl checkListControl1;
        private System.Windows.Forms.ToolStripMenuItem swapWithMapToolStripMenuItem;
        private Controls.MyButton BUT_abortland;
        private Controls.MyButton but_disablejoystick;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordHudToAVIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setMJPEGSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PointCameraCoordsToolStripMenuItem1;
        private Controls.ModifyandSet modifyandSetLoiterRad;
        private System.Windows.Forms.ToolStripMenuItem onOffCameraOverlapToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripQuickView;
        private System.Windows.Forms.ToolStripMenuItem setViewCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setGStreamerSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setEKFHomeHereToolStripMenuItem;
        public System.Windows.Forms.TabPage tabPayload;
        private System.Windows.Forms.BindingSource bindingSourcePayloadTab;
        private System.Windows.Forms.TrackBar trackBarYaw;
        private System.Windows.Forms.TrackBar trackBarRoll;
        private System.Windows.Forms.TrackBar trackBarPitch;
        private Controls.MyButton BUT_resetGimbalPos;
        private System.Windows.Forms.TextBox TXT_gimbalPitchPos;
        private System.Windows.Forms.TextBox TXT_gimbalYawPos;
        private System.Windows.Forms.TextBox TXT_gimbalRollPos;
        private System.Windows.Forms.GroupBox groupBoxRoll;
        private System.Windows.Forms.GroupBox groupBoxYaw;
        private System.Windows.Forms.GroupBox groupBoxPitch;
        private Controls.MyButton BUT_GimbalVideo;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem groundColorToolStripMenuItem;
        private Controls.RelayOptions relayOptions1;
        private Controls.RelayOptions relayOptions2;
        private Controls.RelayOptions relayOptions3;
        private Controls.RelayOptions relayOptions4;
        private Controls.RelayOptions relayOptions5;
        private Controls.RelayOptions relayOptions6;
        private System.Windows.Forms.ToolStripMenuItem hereLinkVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gStreamerStopToolStripMenuItem;
        private Controls.MyButton BUT_georefimage;
        private Controls.QuickView quickView6;
        private Controls.QuickView quickView5;
        private System.Windows.Forms.ToolStripMenuItem poiatcoordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flyToCoordsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem setBatteryCellCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undockToolStripMenuItem;
        private System.Windows.Forms.Button ALT_btn;
        private System.Windows.Forms.Button STBY_btn;
        private System.Windows.Forms.Button ON_btn;
        private System.Windows.Forms.CheckedListBox Mode_clb;
        private System.Windows.Forms.NumericUpDown Squawk_nud;
        private System.Windows.Forms.Label Squawk_label;
        private System.Windows.Forms.Label FlightID_label;
        private System.Windows.Forms.TextBox FlightID_tb;
        private System.Windows.Forms.Button IDENT_btn;
        public System.Windows.Forms.TabPage tabTransponder;
        private System.Windows.Forms.Button XPDRConnect_btn;
        private System.Windows.Forms.CheckedListBox fault_clb;
        private System.Windows.Forms.Label NACp_lbl;
        private System.Windows.Forms.Label NIC_lbl;
        private System.Windows.Forms.TextBox NACp_tb;
        private System.Windows.Forms.TextBox NIC_tb;
        private ToolStripMenuItem showIconsToolStripMenuItem;
        private ToolStripMenuItem multiLineToolStripMenuItem;
        private Controls.MyButton BUT_SendMSG;
        public Panel panel_persistent;
        public System.Windows.Forms.TabPage tabAuxFunction;
        private FlowLayoutPanel flowLayoutPanel1;
        private Controls.AuxOptions auxOptions1;
        private Controls.AuxOptions auxOptions2;
        private Controls.AuxOptions auxOptions3;
        private Controls.AuxOptions auxOptions4;
        private Controls.AuxOptions auxOptions5;
        private Controls.AuxOptions auxOptions6;
        private Controls.AuxOptions auxOptions7;
        private ToolStripMenuItem jumpToTagToolStripMenuItem;
        private Controls.RelayOptions relayOptions7;
        private Controls.RelayOptions relayOptions8;
        private Controls.RelayOptions relayOptions9;
        private Controls.RelayOptions relayOptions10;
        private Controls.RelayOptions relayOptions11;
        private Controls.RelayOptions relayOptions12;
        private Controls.RelayOptions relayOptions13;
        private Controls.RelayOptions relayOptions14;
        private Controls.RelayOptions relayOptions15;
        private Controls.RelayOptions relayOptions16;
        private ToolStripMenuItem gimbalVideoToolStripMenuItem;
        private ToolStripMenuItem gimbalVideoFullSizedToolStripMenuItem;
        private ToolStripMenuItem gimbalVideoMiniToolStripMenuItem;
        private ToolStripMenuItem gimbalVideoPopOutToolStripMenuItem;
    }
}
