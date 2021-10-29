using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace api.Models
{
    public partial class ProductionContext : DbContext
    {
        public ProductionContext()
        {
        }

        public ProductionContext(DbContextOptions<ProductionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountResign> AccountResigns { get; set; }
        public virtual DbSet<AoiRepairReport> AoiRepairReports { get; set; }
        public virtual DbSet<AoiReport> AoiReports { get; set; }
        public virtual DbSet<ChangLineWork> ChangLineWorks { get; set; }
        public virtual DbSet<ChangePart> ChangeParts { get; set; }
        public virtual DbSet<ChinTekMail> ChinTekMails { get; set; }
        public virtual DbSet<DipConsumable> DipConsumables { get; set; }
        public virtual DbSet<DipConsumablesRecord> DipConsumablesRecords { get; set; }
        public virtual DbSet<DipOven> DipOvens { get; set; }
        public virtual DbSet<DipReport> DipReports { get; set; }
        public virtual DbSet<Electricity> Electricities { get; set; }
        public virtual DbSet<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual DbSet<ExcessAoiRepair> ExcessAoiRepairs { get; set; }
        public virtual DbSet<FeedStation> FeedStations { get; set; }
        public virtual DbSet<FeederCar> FeederCars { get; set; }
        public virtual DbSet<FeederNumber> FeederNumbers { get; set; }
        public virtual DbSet<FeederOnRecord> FeederOnRecords { get; set; }
        public virtual DbSet<GiftMatch> GiftMatches { get; set; }
        public virtual DbSet<HumanResource> HumanResources { get; set; }
        public virtual DbSet<Iqcdatabase> Iqcdatabases { get; set; }
        public virtual DbSet<JigList> JigLists { get; set; }
        public virtual DbSet<LineStorageIn> LineStorageIns { get; set; }
        public virtual DbSet<Lunch> Lunches { get; set; }
        public virtual DbSet<Meet> Meets { get; set; }
        public virtual DbSet<MesFlow> MesFlows { get; set; }
        public virtual DbSet<MesModelInformation> MesModelInformations { get; set; }
        public virtual DbSet<MesRepair> MesRepairs { get; set; }
        public virtual DbSet<MesRepairDip> MesRepairDips { get; set; }
        public virtual DbSet<MesRepairTest> MesRepairTests { get; set; }
        public virtual DbSet<Moistureproof> Moistureproofs { get; set; }
        public virtual DbSet<OqcMesCheckList> OqcMesCheckLists { get; set; }
        public virtual DbSet<OrderInformation> OrderInformations { get; set; }
        public virtual DbSet<Oven> Ovens { get; set; }
        public virtual DbSet<OvenInformation> OvenInformations { get; set; }
        public virtual DbSet<OxygenRec> OxygenRecs { get; set; }
        public virtual DbSet<PackageReport> PackageReports { get; set; }
        public virtual DbSet<PcbaTransfer> PcbaTransfers { get; set; }
        public virtual DbSet<PcbaTransferRec> PcbaTransferRecs { get; set; }
        public virtual DbSet<ProdMatList> ProdMatLists { get; set; }
        public virtual DbSet<ProductLocation> ProductLocations { get; set; }
        public virtual DbSet<ProductLocationTmp> ProductLocationTmps { get; set; }
        public virtual DbSet<ProgramVersion> ProgramVersions { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<PurchaseDatabase> PurchaseDatabases { get; set; }
        public virtual DbSet<PurchaseStatus> PurchaseStatuses { get; set; }
        public virtual DbSet<ReflowRec> ReflowRecs { get; set; }
        public virtual DbSet<ReflowStandard> ReflowStandards { get; set; }
        public virtual DbSet<Replacement> Replacements { get; set; }
        public virtual DbSet<SmtSteel> SmtSteels { get; set; }
        public virtual DbSet<SmtSteelRecord> SmtSteelRecords { get; set; }
        public virtual DbSet<SolderPaste> SolderPastes { get; set; }
        public virtual DbSet<StaticBox> StaticBoxes { get; set; }
        public virtual DbSet<Stencil> Stencils { get; set; }
        public virtual DbSet<StencilsRec> StencilsRecs { get; set; }
        public virtual DbSet<T340Model> T340Models { get; set; }
        public virtual DbSet<T607Product> T607Products { get; set; }
        public virtual DbSet<T623Imei> T623Imeis { get; set; }
        public virtual DbSet<T625ProdMatch> T625ProdMatches { get; set; }
        public virtual DbSet<T625Product> T625Products { get; set; }
        public virtual DbSet<T630Model> T630Models { get; set; }
        public virtual DbSet<T641> T641s { get; set; }
        public virtual DbSet<T6413Pid> T6413Pids { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<TestReport> TestReports { get; set; }
        public virtual DbSet<TorqueInfo> TorqueInfos { get; set; }
        public virtual DbSet<TorqueRec> TorqueRecs { get; set; }
        public virtual DbSet<TorqueTmp> TorqueTmps { get; set; }
        public virtual DbSet<WhDeletelist> WhDeletelists { get; set; }
        public virtual DbSet<YouTubeUrl> YouTubeUrls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Server=192.168.0.201;Database=Production;User ID=sa;Password=chi;Trusted_Connection=True;Integrated Security=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Password);

                entity.ToTable("Account");

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.AccountingCheck)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("accounting_check")
                    .HasDefaultValueSql("('無使用')");

                entity.Property(e => e.Appdate)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("appdate");

                entity.Property(e => e.Deptname)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("deptname");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Idenable)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("idenable")
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ItCheck)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("it_check")
                    .HasDefaultValueSql("('無使用')");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NewId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NewID");

                entity.Property(e => e.Sysmanager)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sysmanager")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.班別)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AccountResign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Account_resign");

                entity.Property(e => e.AccountingCheck)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("accounting_check")
                    .HasDefaultValueSql("('無使用')");

                entity.Property(e => e.Applydate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("applydate");

                entity.Property(e => e.Dept)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dept");

                entity.Property(e => e.ItCheck)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("it_check")
                    .HasDefaultValueSql("('無使用')");

                entity.Property(e => e.Name)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Resigndate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("resigndate");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('未結案')");
            });

            modelBuilder.Entity<AoiRepairReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AOI_Repair_Report");

                entity.Property(e => e.不良位置)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.不良原因)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.他責)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.修復)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.備註)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.序號)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.提交時間)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.日期)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.維修人員)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.自責)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.製程站)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AoiReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AOI_Report");

                entity.Property(e => e.上傳時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.作業人員)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.日期)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.生產良率)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.製程站)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.試產)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChangLineWork>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChangLineWork");

                entity.Property(e => e.Bom核對)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BOM核對");

                entity.Property(e => e.Cpk)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CPK");

                entity.Property(e => e.Sop參數)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SOP參數");

                entity.Property(e => e.XRay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("X-ray");

                entity.Property(e => e.印刷機)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.印刷確認)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.吸嘴)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.收板機)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.時間).HasColumnType("datetime");

                entity.Property(e => e.極性確認)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.氮氣)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.爐溫)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.空板)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.線別)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.線長)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.裝著點)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.送板機)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.鋼板厚度)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.鋼板執行)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.鋼板編號)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.錫膏型號)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.錫膏編號)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.開封日期).HasColumnType("datetime");

                entity.Property(e => e.隨線)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.面板)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.頂pin確認)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("頂Pin確認");

                entity.Property(e => e.頂針)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.首件執行)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.首件確認)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.點膠)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChangePart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChangePart");

                entity.Property(e => e.主料料號)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.替代用料料號)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.變更人)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.變更時間)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChinTekMail>(entity =>
            {
                entity.ToTable("ChinTek_mail");

                entity.Property(e => e.MailAddress)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("Mail_Address");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NickName)
                    .IsUnicode(false)
                    .HasColumnName("nick_name");
            });

            modelBuilder.Entity<DipConsumable>(entity =>
            {
                entity.HasKey(e => e.規格)
                    .HasName("PK__tmp_ms_x__1EAE12673F5607A3");

                entity.ToTable("Dip_consumables");

                entity.Property(e => e.規格)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.品名)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.操作人員)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.操作時間)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DipConsumablesRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dip_Consumables_Record");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.品名)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.操作人員)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.操作時間)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.數量)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.狀態)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.規格)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DipOven>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DIP_Oven");

                entity.Property(e => e.取出人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.取出時間).HasColumnType("datetime");

                entity.Property(e => e.品名規格)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("品名/規格");

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.烘烤人員)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.烘烤開始時間).HasColumnType("datetime");

                entity.Property(e => e.結案)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.預計完成時間).HasColumnType("datetime");
            });

            modelBuilder.Entity<DipReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DIP_Report");

                entity.Property(e => e.上傳時間)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.作業人員)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.廠別)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.日期)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.生產良率)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.製程站)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.試產)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Electricity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("electricity");

                entity.Property(e => e.名字)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.日期)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.狀態)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.班別)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.確認人員)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.資料時間).HasColumnType("datetime");

                entity.Property(e => e.部門)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ErpWorkOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ERP_WorkOrder");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BillNO");

                entity.Property(e => e.Client)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ClientID");

                entity.Property(e => e.CustBillNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustProdId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CustProdID");

                entity.Property(e => e.ProdId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");
            });

            modelBuilder.Entity<ExcessAoiRepair>(entity =>
            {
                entity.HasKey(e => e.領收時間);

                entity.ToTable("Excess_AOI_Repair");

                entity.Property(e => e.領收時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.單號)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.料號)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.領收人員)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FeedStation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Feed_Station");

                entity.Property(e => e.客戶別)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.料號)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FeederCar>(entity =>
            {
                entity.HasKey(e => e.站別)
                    .HasName("PK__tmp_ms_x__1E2C5CC00B91BA14");

                entity.ToTable("FeederCar");

                entity.Property(e => e.站別)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.作業人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.掃描時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.料架號碼)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.車號)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FeederNumber>(entity =>
            {
                entity.HasKey(e => e.料架號碼)
                    .HasName("PK__tmp_ms_x__6B61AA8557DD0BE4");

                entity.ToTable("FeederNumber");

                entity.Property(e => e.料架號碼)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Po)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PO");

                entity.Property(e => e.上料人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.上料時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.客戶別)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.料號)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.進料週期)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FeederOnRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FeederOn_Record");

                entity.Property(e => e.匯出人員)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.匯出時間)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.製程面)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GiftMatch>(entity =>
            {
                entity.HasKey(e => e.Mac)
                    .HasName("PK__Gift_Mat__C790778D2A9F7F05");

                entity.ToTable("Gift_Match");

                entity.Property(e => e.Mac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAC");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SN");
            });

            modelBuilder.Entity<HumanResource>(entity =>
            {
                entity.HasKey(e => e.身分證字號);

                entity.Property(e => e.身分證字號)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Erp編號)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ERP編號");

                entity.Property(e => e.Mail帳號)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.人因)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.伸縮環與識別帶)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.保密條款)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.個人工具盒)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.入職時間)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.內務櫃鑰匙)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.內部資安威脅防範對策)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.兵役情況)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.其他1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.其他2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.出生日期)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.員工守則)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.員工編號)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.大門鑰匙)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.姓名)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.婚姻)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.工作場所性騷擾防治措施申訴及懲戒辦法)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.工商日誌)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.工廠守則)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.帽子編號1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.帽子編號2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.性別)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.戶籍地址)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.手機號碼)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.最高學歷)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.正航帳號)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.汽車駕照)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.注意事項)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.用餐隔板)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.畢業年)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.科系)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.緊急聯絡人)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.美工刀)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.聯絡人關係)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.聯絡人電話)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.職稱)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.通訊地址)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.部門)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.門禁卡)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.靜電手環)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.靜電衣編號1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.靜電衣編號2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.靜電鞋)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.預防職場暴力之書面聲明)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.餐廳守則)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Iqcdatabase>(entity =>
            {
                entity.HasKey(e => e.原廠編號)
                    .HasName("PK__tmp_ms_x__1C4150C503F0984C");

                entity.ToTable("IQCdatabase");

                entity.Property(e => e.原廠編號).HasMaxLength(50);

                entity.Property(e => e.料單料號).IsRequired();
            });

            modelBuilder.Entity<JigList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Jig_List");

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.編號)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LineStorageIn>(entity =>
            {
                entity.HasKey(e => e.卷號)
                    .HasName("PK__tmp_ms_x__30B512DC3CF40B7E");

                entity.ToTable("LineStorageIn");

                entity.Property(e => e.卷號)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Dc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Po)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PO");

                entity.Property(e => e.入料人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.入料時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.客戶別)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.料號)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.格號)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.櫃號)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.進料週期)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lunch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Lunch");

                entity.Property(e => e.日期)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.素食飯)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.素食麵)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.葷食)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.部門)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Meet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("meet");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.備註).IsUnicode(false);

                entity.Property(e => e.執行人員)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.完成時間)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.日期)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.是否結束)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.會議主旨).IsUnicode(false);

                entity.Property(e => e.確認單位)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.與會人).IsUnicode(false);

                entity.Property(e => e.追蹤事項).IsUnicode(false);
            });

            modelBuilder.Entity<MesFlow>(entity =>
            {
                entity.HasKey(e => e.流程代碼)
                    .HasName("PK__tmp_ms_x__73BD4E1F93AC3857");

                entity.ToTable("MES_Flow");

                entity.Property(e => e.流程代碼).ValueGeneratedNever();

                entity.Property(e => e.站別1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別10)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別11)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別12)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別13)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別14)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別15)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別16)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別17)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別18)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別19)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別20)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別4)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別5)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別6)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別7)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別8)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.站別9)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MesModelInformation>(entity =>
            {
                entity.HasKey(e => e.機種)
                    .HasName("PK__tmp_ms_x__1D559F3DE6457245");

                entity.ToTable("MES_ModelInformation");

                entity.Property(e => e.機種)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.序號種類)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.建立時間)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.建立者)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MesRepair>(entity =>
            {
                entity.HasKey(e => e.入帳時間)
                    .HasName("PK__tmp_ms_x__6EEF66984E53A1AA");

                entity.ToTable("MES_Repair");

                entity.Property(e => e.入帳時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.人員)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.位置)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.修復)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.完修時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.序號)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.日期)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.現象)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.製程站)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MesRepairDip>(entity =>
            {
                entity.HasKey(e => e.入帳時間)
                    .HasName("PK__MES_Repa__6EEF66985D95E53A");

                entity.ToTable("MES_Repair_DIP");

                entity.Property(e => e.入帳時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.人員)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.位置)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.完修時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.序號)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.日期)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.現象)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.製程站)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MesRepairTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MES_Repair_TEST");

                entity.Property(e => e.上傳時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.不良代碼)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.不良位置)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.不良原因)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.他責)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.代碼)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.修復)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.備註)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.入帳時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.客戶)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.客戶機種)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.序號)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.日期)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.測試站)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.現象)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.維修人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.維修時間)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.自責)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.製程站)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Moistureproof>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Moistureproof");

                entity.Property(e => e.儲位)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.原廠料號)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.取出人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.取出時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.客戶別)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.放入人員)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.放入時間)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.數量)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.料單料號)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.結案)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OqcMesCheckList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OQC_MES_CheckList");

                entity.Property(e => e.工單編號)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.抽檢結果)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.退貨原因)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.退貨標準)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.類別)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.驗貨人員)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.驗貨時間)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrderInformation");

                entity.Property(e => e.FlowId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FlowID");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrder)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Oven>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Oven");

                entity.Property(e => e.儲位)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.取出人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.取出時間).HasColumnType("datetime");

                entity.Property(e => e.客戶別)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.料號)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.烘烤人員)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.烘烤時數)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.烘烤開始時間).HasColumnType("datetime");

                entity.Property(e => e.結案)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.預計完成時間).HasColumnType("datetime");
            });

            modelBuilder.Entity<OvenInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OvenInformation");

                entity.Property(e => e.客戶別)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.建立者)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.類別)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OxygenRec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Oxygen_Rec");

                entity.Property(e => e.時間).HasColumnType("datetime");

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.檢查)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.確認)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.線別)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PackageReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Package_Report");

                entity.Property(e => e.作業人員)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.效率)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.站別)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.結束時間)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.開始時間)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PcbaTransfer>(entity =>
            {
                entity.HasKey(e => e.製令);

                entity.ToTable("PCBA_Transfer");

                entity.Property(e => e.製令)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Aoi).HasColumnName("AOI");

                entity.Property(e => e.Aoi1).HasColumnName("AOI-1");

                entity.Property(e => e.Dip).HasColumnName("DIP");

                entity.Property(e => e.Dip1).HasColumnName("DIP-1");

                entity.Property(e => e.Dip2).HasColumnName("DIP-2");

                entity.Property(e => e.Iqc).HasColumnName("IQC");

                entity.Property(e => e.Oqc).HasColumnName("OQC");

                entity.Property(e => e.Qa).HasColumnName("QA");

                entity.Property(e => e.Qa1).HasColumnName("QA-1");

                entity.Property(e => e.Test).HasColumnName("TEST");

                entity.Property(e => e.Test1).HasColumnName("TEST-1");

                entity.Property(e => e.Test2).HasColumnName("TEST-2");

                entity.Property(e => e.倉庫1).HasColumnName("倉庫-1");

                entity.Property(e => e.備註)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.外包1).HasColumnName("外包-1");

                entity.Property(e => e.客戶機種)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.工單)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.組包1).HasColumnName("組包-1");

                entity.Property(e => e.組包2).HasColumnName("組包-2");
            });

            modelBuilder.Entity<PcbaTransferRec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PCBA_Transfer_rec");

                entity.Property(e => e.備註)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.客戶機種)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.工單)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.接收人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.接收單位)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.時間).HasColumnType("datetime");

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.轉出人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.轉出單位)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProdMatList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("prodMatList");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BillNO");

                entity.Property(e => e.Caution)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MainProdId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MainProdID");

                entity.Property(e => e.PartName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProSide)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProdModel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PushTime)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Worker)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductLocation>(entity =>
            {
                entity.HasKey(e => e.編號)
                    .HasName("PK__tmp_ms_x__1DCB58714A2C1BBA");

                entity.ToTable("Product_Location");

                entity.Property(e => e.編號)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cpu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CPU");

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ram)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RAM");

                entity.Property(e => e.人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.作業系統)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.保管人)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.保養週期)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.備註)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.儲位)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.初盤人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.初盤日期).HasColumnType("date");

                entity.Property(e => e.名稱)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.報廢人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.報廢原因)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.客戶財編)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.時間).HasColumnType("datetime");

                entity.Property(e => e.校正日期).HasColumnType("date");

                entity.Property(e => e.硬碟)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.移轉)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.覆盤人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.覆盤日期).HasColumnType("date");

                entity.Property(e => e.購入日期).HasColumnType("date");

                entity.Property(e => e.部門)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.預計保養).HasColumnType("date");
            });

            modelBuilder.Entity<ProductLocationTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Product_Location_Tmp");

                entity.Property(e => e.Cpu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CPU");

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ram)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RAM");

                entity.Property(e => e.人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.作業系統)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.保管人)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.保養週期)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.備註)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.儲位)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.初盤人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.初盤日期).HasColumnType("date");

                entity.Property(e => e.原儲位)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.原因)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.名稱)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.報廢人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.報廢原因)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.客戶財編)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.新保養週期)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.新儲位)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.新名稱)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.新客戶財編)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.新校正日期)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.新預計保養)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.日期).HasColumnType("date");

                entity.Property(e => e.時間).HasColumnType("datetime");

                entity.Property(e => e.校正日期)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.硬碟)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.移轉)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.編號)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.覆盤人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.覆盤日期).HasColumnType("date");

                entity.Property(e => e.購入日期).HasColumnType("date");

                entity.Property(e => e.部門)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.項目)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.預計保養)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProgramVersion>(entity =>
            {
                entity.HasKey(e => e.程式名稱);

                entity.ToTable("ProgramVersion");

                entity.Property(e => e.程式名稱)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.版本)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Purchase");

                entity.Property(e => e.Po)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PO");

                entity.Property(e => e.出貨日)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.列帳)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.品名規格)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.單位)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.廠商)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.廠商代號)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.急單)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.數量)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.產品編號)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.產編號碼)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.用途說明).IsUnicode(false);

                entity.Property(e => e.申請單位)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.編立日期)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.請購人員)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.請購單號)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.請購日期).HasColumnType("date");
            });

            modelBuilder.Entity<PurchaseDatabase>(entity =>
            {
                entity.HasKey(e => e.產品編號)
                    .HasName("PK__Purchase__66B63141398D8EEE");

                entity.ToTable("PurchaseDatabase");

                entity.Property(e => e.產品編號)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.品名規格)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.廠商代號)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.廠商名稱)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseStatus>(entity =>
            {
                entity.HasKey(e => e.單號)
                    .HasName("PK__Purchase__30A54A8034C8D9D1");

                entity.ToTable("PurchaseStatus");

                entity.Property(e => e.單號).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.主管)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.代核)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.作廢人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.作廢原因)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.作廢時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.副總)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.採購)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.最後簽核時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.狀態)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.處長)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReflowRec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Reflow_Rec");

                entity.Property(e => e.執行)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.時間).HasColumnType("datetime");

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.確認)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.線別)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.速率)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReflowStandard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Reflow_standard");

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.線別)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.速率)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Replacement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Replacement");

                entity.Property(e => e.Po)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PO");

                entity.Property(e => e.工號)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.數量).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.料號)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.時間)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.站別)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.線別)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.覆核人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.覆核時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.週期)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmtSteel>(entity =>
            {
                entity.HasKey(e => e.鋼板編號)
                    .HasName("PK__tmp_ms_x__ADD89FC4CB87038F");

                entity.ToTable("SMT_Steel");

                entity.Property(e => e.鋼板編號)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.上線時間)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.下線時間)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.印刷次數)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.取用者)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.歸還者)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.清潔鋼板)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.測量1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.測量2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.測量3)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.測量4)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.測量5)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.線別)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmtSteelRecord>(entity =>
            {
                entity.ToTable("SMT_Steel_Record");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.上線時間)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.下線時間)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.印刷次數)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.取用者)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.歸還者)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.清潔鋼板)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.測量1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.測量2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.測量3)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.測量4)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.測量5)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.線別)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.鋼板編號)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SolderPaste>(entity =>
            {
                entity.HasKey(e => e.錫膏編號)
                    .HasName("PK__tmp_ms_x__96A30AFD37EC434D");

                entity.ToTable("SolderPaste");

                entity.Property(e => e.錫膏編號)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.取出時間).HasColumnType("datetime");

                entity.Property(e => e.取用人員)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.執行人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.報廢人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.報廢原因)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.報廢時間)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.報廢確認)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.攪拌時間)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.旗標).HasDefaultValueSql("((1))");

                entity.Property(e => e.確認人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.重量)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.錫膏型號)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.錫膏廠牌)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StaticBox>(entity =>
            {
                entity.HasKey(e => e.卷數)
                    .HasName("PK__tmp_ms_x__30B571B5540C7B00");

                entity.ToTable("StaticBox");

                entity.Property(e => e.卷數)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Po)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PO");

                entity.Property(e => e.作業人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.入箱時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.客戶別)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.料號)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.箱號)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.進料週期)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Stencil>(entity =>
            {
                entity.HasKey(e => e.編號);

                entity.Property(e => e.編號)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pcb料號)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PCB料號");

                entity.Property(e => e.備註)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.報廢日期).HasColumnType("date");

                entity.Property(e => e.報廢通知)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.客供編號)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.客戶別)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.拆除日期).HasColumnType("date");

                entity.Property(e => e.拆除通知)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.業者製造編號)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.製造日期).HasColumnType("date");

                entity.Property(e => e.退還人)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.退還日期).HasColumnType("date");

                entity.Property(e => e.進廠日期).HasColumnType("date");

                entity.Property(e => e.鋼板別)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.鋼板厚度)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.鋼板取用時間).HasColumnType("date");

                entity.Property(e => e.鋼板尺寸)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.鋼板檔名)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.附件1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.附件2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.附件3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.附件4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.附件5)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.附件6)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.附件7)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StencilsRec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stencils_Rec");

                entity.Property(e => e.Pcb料號)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PCB料號");

                entity.Property(e => e.人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.備註)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.報廢日期).HasColumnType("date");

                entity.Property(e => e.報廢通知)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.客供編號)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.客戶別)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.拆除日期).HasColumnType("date");

                entity.Property(e => e.拆除通知)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.時間).HasColumnType("datetime");

                entity.Property(e => e.業者製造編號)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.編號)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.製造日期).HasColumnType("date");

                entity.Property(e => e.退還人)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.退還時間).HasColumnType("date");

                entity.Property(e => e.進廠日期).HasColumnType("date");

                entity.Property(e => e.鋼板厚度)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.鋼板取用時間).HasColumnType("date");

                entity.Property(e => e.鋼板尺寸)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.鋼板檔名)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.附件1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.附件2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.附件3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.附件4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.附件5)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.附件6)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.附件7)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.項目)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<T340Model>(entity =>
            {
                entity.HasKey(e => e.機種);

                entity.ToTable("T340_Model");

                entity.Property(e => e.機種)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.品名)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.品號)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<T607Product>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T607_Product");

                entity.Property(e => e.Rx列印)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Rx 列印");

                entity.Property(e => e.SN)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("S/N");

                entity.Property(e => e.SN建立人員)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("S/N 建立人員");

                entity.Property(e => e.SN建立時間)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("S/N 建立時間");

                entity.Property(e => e.Tx列印)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Tx 列印");

                entity.Property(e => e.安規列印人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.安規列印時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.客戶機種)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.工單)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.彩盒列印)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.彩盒列印人員)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.彩盒列印時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<T623Imei>(entity =>
            {
                entity.HasKey(e => e.Imei)
                    .HasName("PK__tmp_ms_x__8DF371FC2B3F6F97");

                entity.ToTable("T623_IMEI");

                entity.Property(e => e.Imei)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IMEI");

                entity.Property(e => e.Package)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PackageTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SN)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("S/N");
            });

            modelBuilder.Entity<T625ProdMatch>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("T625_Prod_Match");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.Mac)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MAC");

                entity.Property(e => e.Model1)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Model-1");

                entity.Property(e => e.Model2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Model-2");

                entity.Property(e => e.Model3)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Model-3");

                entity.Property(e => e.Model4)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Model-4");

                entity.Property(e => e.Model5)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Model-5");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.Worker)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.貼紙mac)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("貼紙MAC");

                entity.Property(e => e.貼紙sn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("貼紙SN");
            });

            modelBuilder.Entity<T625Product>(entity =>
            {
                entity.HasKey(e => e.SN)
                    .HasName("PK__T625_Pro__CA1DFBCA703EA55A");

                entity.ToTable("T625_Product");

                entity.Property(e => e.SN)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("S/N");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BillNO");

                entity.Property(e => e.Mac)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("MAC");

                entity.Property(e => e.Model1)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Model-1");

                entity.Property(e => e.Model2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Model-2");

                entity.Property(e => e.Model3)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Model-3");

                entity.Property(e => e.Model4)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Model-4");

                entity.Property(e => e.Package)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PackingTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Packing_time");

                entity.Property(e => e.ProdId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ProdID");

                entity.Property(e => e.Worker)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<T630Model>(entity =>
            {
                entity.HasKey(e => e.機種)
                    .HasName("PK__T630_Mod__1D559F3D282DF8C2");

                entity.ToTable("T630_Model");

                entity.Property(e => e.機種)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.品名)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.料號)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.規格)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<T641>(entity =>
            {
                entity.HasKey(e => e.禮盒sn);

                entity.ToTable("T641");

                entity.Property(e => e.禮盒sn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("禮盒SN");

                entity.Property(e => e.Mac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAC");

                entity.Property(e => e.包裝人員)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.包裝時間)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.匹配時間)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.外箱aid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("外箱AID");

                entity.Property(e => e.操作人員)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.產品號)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.週別)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<T6413Pid>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__T641_3_P__C577552027C6EBD6");

                entity.ToTable("T641_3_PID");

                entity.Property(e => e.Pid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PID");
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.HasKey(e => e.日期)
                    .HasName("PK__Table__1C8ECE0B6DDBC832");

                entity.ToTable("Table");

                entity.Property(e => e.日期).ValueGeneratedNever();

                entity.Property(e => e.名字)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.資料時間)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.部門)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TestReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_Report");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.上傳時間)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.不良率)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.作業人員)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.備註).IsUnicode(false);

                entity.Property(e => e.效率)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.站別)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TorqueInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Torque_info");

                entity.Property(e => e.人員)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.時間).HasColumnType("datetime");

                entity.Property(e => e.標準扭力值).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.編號)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.製程)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.誤差值).HasColumnType("decimal(4, 2)");
            });

            modelBuilder.Entity<TorqueRec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Torque_Rec");

                entity.Property(e => e.日期).HasColumnType("date");

                entity.Property(e => e.標準扭力值)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.測試扭力值)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.編號)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.蜂鳴器)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.製令)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.製程)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.誤差值)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.量測人員)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.量測時間).HasColumnType("datetime");

                entity.Property(e => e.電動起子編號)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TorqueTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Torque_TMP");

                entity.Property(e => e.日期).HasColumnType("date");

                entity.Property(e => e.標準扭力值)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.測試扭力值)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.編號)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.蜂鳴器)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.製程)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.誤差值)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.量測人員)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.量測時間).HasColumnType("datetime");

                entity.Property(e => e.電動起子編號)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.項目)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WhDeletelist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Wh_Deletelist");

                entity.Property(e => e.倉別)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.刪除人員)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.刪除時間)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.刪除項目)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.數量)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.料號)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.時間)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.資料庫)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YouTubeUrl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YouTube_Url");

                entity.Property(e => e.操作人)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.操作時間)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.機種)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.網址)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.部門)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
