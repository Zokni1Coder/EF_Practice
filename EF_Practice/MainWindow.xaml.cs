using EF_Practice.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EF_Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class ComponentsContext : DbContext
    {
        public ComponentsContext() : base("PC_ComponentsConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ComponentsContext, EF_Practice.Migrations.Configuration>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<CPU_Cooler> CPU_Coolers { get; set; }
        public DbSet<CPU_Microarchitecture> CPU_Microarchitectures { get; set; }
        public DbSet<CPU_Serie> CPU_Series { get; set; }
        public DbSet<CPU_Socket> CPU_Sockets { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<GPU_frame_sync> GPU_frame_syncs { get; set;}
        public DbSet<GPU_technology> GPU_Technologies { get; set; }
        public DbSet<Component_interface> Component_interfaces { get; set; }
        public DbSet<M2> M2s { get; set; }
        public DbSet<M2_form_factor> M2_form_factors { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<Motherboard_chipset> Motherboard_chipsets { get; set; }
        public DbSet<Motherboard_form_factor> Motherboard_form_factors { get; set; }
        public DbSet<PS> PSs { get; set; }
        public DbSet<PS_form_factor> PS_form_factors { get; set; }
        public DbSet<PS_Rating> PS_Ratings { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<RAM_type> RAM_types { get; set; }
        public DbSet<ROM> ROMs { get; set; }
        public DbSet<ROM_form_factor> ROM_form_factors { get; set; }
        public DbSet<ROM_Type> ROM_Types { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
