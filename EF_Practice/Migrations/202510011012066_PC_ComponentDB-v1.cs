namespace EF_Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PC_ComponentDBv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Component_interface",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        interface_type = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.GPUs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        model = c.String(),
                        brand = c.String(),
                        vram = c.Int(nullable: false),
                        core_clock = c.Int(nullable: false),
                        boost_clock = c.Int(nullable: false),
                        tdp = c.Int(nullable: false),
                        hdmi_output = c.Int(nullable: false),
                        dp_port_output = c.Int(nullable: false),
                        price = c.Int(nullable: false),
                        GPU_frame_Sync_id = c.Int(),
                        gpu_interface_id = c.Int(),
                        GPU_technology_id = c.Int(),
                        ram_type_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.GPU_frame_sync", t => t.GPU_frame_Sync_id)
                .ForeignKey("dbo.Component_interface", t => t.gpu_interface_id)
                .ForeignKey("dbo.GPU_technology", t => t.GPU_technology_id)
                .ForeignKey("dbo.RAM_type", t => t.ram_type_id)
                .Index(t => t.GPU_frame_Sync_id)
                .Index(t => t.gpu_interface_id)
                .Index(t => t.GPU_technology_id)
                .Index(t => t.ram_type_id);
            
            CreateTable(
                "dbo.GPU_frame_sync",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        sync = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.GPU_technology",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        technology = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CPU_Cooler",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        model = c.String(),
                        fan_rpm = c.Int(nullable: false),
                        noise_level = c.Double(nullable: false),
                        water_cooled = c.Boolean(nullable: false),
                        price = c.Int(nullable: false),
                        manufacturer_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Manufacturers", t => t.manufacturer_id)
                .Index(t => t.manufacturer_id);
            
            CreateTable(
                "dbo.CPU_Socket",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        type = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CPUs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        core_count = c.Int(nullable: false),
                        thread_count = c.Int(nullable: false),
                        core_clock = c.Double(nullable: false),
                        boost_core_clock = c.Double(nullable: false),
                        L2_Cache = c.Int(nullable: false),
                        L3_Cache = c.Int(nullable: false),
                        tdp = c.Int(nullable: false),
                        int_graph = c.Int(nullable: false),
                        price = c.Int(nullable: false),
                        model = c.String(),
                        manufacturer_id = c.Int(),
                        microarchitecture_id = c.Int(),
                        series_id = c.Int(),
                        socket_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Manufacturers", t => t.manufacturer_id)
                .ForeignKey("dbo.CPU_Microarchitecture", t => t.microarchitecture_id)
                .ForeignKey("dbo.CPU_Serie", t => t.series_id)
                .ForeignKey("dbo.CPU_Socket", t => t.socket_id)
                .Index(t => t.manufacturer_id)
                .Index(t => t.microarchitecture_id)
                .Index(t => t.series_id)
                .Index(t => t.socket_id);
            
            CreateTable(
                "dbo.CPU_Microarchitecture",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        architecture = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CPU_Serie",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        serie = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Motherboards",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        model = c.String(),
                        memory_max = c.Int(nullable: false),
                        memory_slot_no = c.Int(nullable: false),
                        sata_60gbs_no = c.Int(nullable: false),
                        onboard_ethernet = c.Boolean(nullable: false),
                        wifi = c.Boolean(nullable: false),
                        raid_supp = c.Boolean(nullable: false),
                        price = c.Int(nullable: false),
                        manufacturer_id = c.Int(),
                        motherboard_chipset_id = c.Int(),
                        motherboard_form_factor_id = c.Int(),
                        RAM_Type_id = c.Int(),
                        socket_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Manufacturers", t => t.manufacturer_id)
                .ForeignKey("dbo.Motherboard_chipset", t => t.motherboard_chipset_id)
                .ForeignKey("dbo.Motherboard_form_factor", t => t.motherboard_form_factor_id)
                .ForeignKey("dbo.RAM_type", t => t.RAM_Type_id)
                .ForeignKey("dbo.CPU_Socket", t => t.socket_id)
                .Index(t => t.manufacturer_id)
                .Index(t => t.motherboard_chipset_id)
                .Index(t => t.motherboard_form_factor_id)
                .Index(t => t.RAM_Type_id)
                .Index(t => t.socket_id);
            
            CreateTable(
                "dbo.M2",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        form_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.M2_form_factor", t => t.form_id)
                .Index(t => t.form_id);
            
            CreateTable(
                "dbo.M2_form_factor",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        form = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Motherboard_chipset",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        chipset = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Motherboard_form_factor",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        form = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.RAM_type",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ram_type = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.RAMs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        model = c.String(),
                        speed = c.Int(nullable: false),
                        modul = c.Int(nullable: false),
                        size = c.Int(nullable: false),
                        CAS_Latency = c.Int(nullable: false),
                        voltage = c.Double(nullable: false),
                        price = c.Int(nullable: false),
                        manufacturer_id = c.Int(),
                        RAM_Type_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Manufacturers", t => t.manufacturer_id)
                .ForeignKey("dbo.RAM_type", t => t.RAM_Type_id)
                .Index(t => t.manufacturer_id)
                .Index(t => t.RAM_Type_id);
            
            CreateTable(
                "dbo.PS",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        model = c.String(),
                        wattage = c.Int(nullable: false),
                        modularity = c.Boolean(nullable: false),
                        price = c.Int(nullable: false),
                        form_id = c.Int(),
                        manufacturer_id = c.Int(),
                        rating_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.PS_form_factor", t => t.form_id)
                .ForeignKey("dbo.Manufacturers", t => t.manufacturer_id)
                .ForeignKey("dbo.PS_Rating", t => t.rating_id)
                .Index(t => t.form_id)
                .Index(t => t.manufacturer_id)
                .Index(t => t.rating_id);
            
            CreateTable(
                "dbo.PS_form_factor",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        form = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PS_Rating",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        rating = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ROMs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        model = c.String(),
                        capacity = c.Int(nullable: false),
                        nvme = c.Boolean(nullable: false),
                        rpm = c.Int(),
                        price = c.Int(nullable: false),
                        _interface_id = c.Int(),
                        form_Factor_id = c.Int(),
                        manufacturer_id = c.Int(),
                        type_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Component_interface", t => t._interface_id)
                .ForeignKey("dbo.ROM_form_factor", t => t.form_Factor_id)
                .ForeignKey("dbo.Manufacturers", t => t.manufacturer_id)
                .ForeignKey("dbo.ROM_Type", t => t.type_id)
                .Index(t => t._interface_id)
                .Index(t => t.form_Factor_id)
                .Index(t => t.manufacturer_id)
                .Index(t => t.type_id);
            
            CreateTable(
                "dbo.ROM_form_factor",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        form_factor = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ROM_Type",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        type = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CPU_SocketCPU_Cooler",
                c => new
                    {
                        CPU_Socket_id = c.Int(nullable: false),
                        CPU_Cooler_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CPU_Socket_id, t.CPU_Cooler_id })
                .ForeignKey("dbo.CPU_Socket", t => t.CPU_Socket_id, cascadeDelete: true)
                .ForeignKey("dbo.CPU_Cooler", t => t.CPU_Cooler_id, cascadeDelete: true)
                .Index(t => t.CPU_Socket_id)
                .Index(t => t.CPU_Cooler_id);
            
            CreateTable(
                "dbo.ManufacturerGPUs",
                c => new
                    {
                        Manufacturer_id = c.Int(nullable: false),
                        GPU_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Manufacturer_id, t.GPU_id })
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_id, cascadeDelete: true)
                .ForeignKey("dbo.GPUs", t => t.GPU_id, cascadeDelete: true)
                .Index(t => t.Manufacturer_id)
                .Index(t => t.GPU_id);
            
            CreateTable(
                "dbo.M2Motherboard",
                c => new
                    {
                        M2_id = c.Int(nullable: false),
                        Motherboard_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.M2_id, t.Motherboard_id })
                .ForeignKey("dbo.M2", t => t.M2_id, cascadeDelete: true)
                .ForeignKey("dbo.Motherboards", t => t.Motherboard_id, cascadeDelete: true)
                .Index(t => t.M2_id)
                .Index(t => t.Motherboard_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ROMs", "type_id", "dbo.ROM_Type");
            DropForeignKey("dbo.ROMs", "manufacturer_id", "dbo.Manufacturers");
            DropForeignKey("dbo.ROMs", "form_Factor_id", "dbo.ROM_form_factor");
            DropForeignKey("dbo.ROMs", "_interface_id", "dbo.Component_interface");
            DropForeignKey("dbo.PS", "rating_id", "dbo.PS_Rating");
            DropForeignKey("dbo.PS", "manufacturer_id", "dbo.Manufacturers");
            DropForeignKey("dbo.PS", "form_id", "dbo.PS_form_factor");
            DropForeignKey("dbo.Motherboards", "socket_id", "dbo.CPU_Socket");
            DropForeignKey("dbo.RAMs", "RAM_Type_id", "dbo.RAM_type");
            DropForeignKey("dbo.RAMs", "manufacturer_id", "dbo.Manufacturers");
            DropForeignKey("dbo.Motherboards", "RAM_Type_id", "dbo.RAM_type");
            DropForeignKey("dbo.GPUs", "ram_type_id", "dbo.RAM_type");
            DropForeignKey("dbo.Motherboards", "motherboard_form_factor_id", "dbo.Motherboard_form_factor");
            DropForeignKey("dbo.Motherboards", "motherboard_chipset_id", "dbo.Motherboard_chipset");
            DropForeignKey("dbo.Motherboards", "manufacturer_id", "dbo.Manufacturers");
            DropForeignKey("dbo.M2Motherboard", "Motherboard_id", "dbo.Motherboards");
            DropForeignKey("dbo.M2Motherboard", "M2_id", "dbo.M2");
            DropForeignKey("dbo.M2", "form_id", "dbo.M2_form_factor");
            DropForeignKey("dbo.ManufacturerGPUs", "GPU_id", "dbo.GPUs");
            DropForeignKey("dbo.ManufacturerGPUs", "Manufacturer_id", "dbo.Manufacturers");
            DropForeignKey("dbo.CPU_Cooler", "manufacturer_id", "dbo.Manufacturers");
            DropForeignKey("dbo.CPUs", "socket_id", "dbo.CPU_Socket");
            DropForeignKey("dbo.CPUs", "series_id", "dbo.CPU_Serie");
            DropForeignKey("dbo.CPUs", "microarchitecture_id", "dbo.CPU_Microarchitecture");
            DropForeignKey("dbo.CPUs", "manufacturer_id", "dbo.Manufacturers");
            DropForeignKey("dbo.CPU_SocketCPU_Cooler", "CPU_Cooler_id", "dbo.CPU_Cooler");
            DropForeignKey("dbo.CPU_SocketCPU_Cooler", "CPU_Socket_id", "dbo.CPU_Socket");
            DropForeignKey("dbo.GPUs", "GPU_technology_id", "dbo.GPU_technology");
            DropForeignKey("dbo.GPUs", "gpu_interface_id", "dbo.Component_interface");
            DropForeignKey("dbo.GPUs", "GPU_frame_Sync_id", "dbo.GPU_frame_sync");
            DropIndex("dbo.M2Motherboard", new[] { "Motherboard_id" });
            DropIndex("dbo.M2Motherboard", new[] { "M2_id" });
            DropIndex("dbo.ManufacturerGPUs", new[] { "GPU_id" });
            DropIndex("dbo.ManufacturerGPUs", new[] { "Manufacturer_id" });
            DropIndex("dbo.CPU_SocketCPU_Cooler", new[] { "CPU_Cooler_id" });
            DropIndex("dbo.CPU_SocketCPU_Cooler", new[] { "CPU_Socket_id" });
            DropIndex("dbo.ROMs", new[] { "type_id" });
            DropIndex("dbo.ROMs", new[] { "manufacturer_id" });
            DropIndex("dbo.ROMs", new[] { "form_Factor_id" });
            DropIndex("dbo.ROMs", new[] { "_interface_id" });
            DropIndex("dbo.PS", new[] { "rating_id" });
            DropIndex("dbo.PS", new[] { "manufacturer_id" });
            DropIndex("dbo.PS", new[] { "form_id" });
            DropIndex("dbo.RAMs", new[] { "RAM_Type_id" });
            DropIndex("dbo.RAMs", new[] { "manufacturer_id" });
            DropIndex("dbo.M2", new[] { "form_id" });
            DropIndex("dbo.Motherboards", new[] { "socket_id" });
            DropIndex("dbo.Motherboards", new[] { "RAM_Type_id" });
            DropIndex("dbo.Motherboards", new[] { "motherboard_form_factor_id" });
            DropIndex("dbo.Motherboards", new[] { "motherboard_chipset_id" });
            DropIndex("dbo.Motherboards", new[] { "manufacturer_id" });
            DropIndex("dbo.CPUs", new[] { "socket_id" });
            DropIndex("dbo.CPUs", new[] { "series_id" });
            DropIndex("dbo.CPUs", new[] { "microarchitecture_id" });
            DropIndex("dbo.CPUs", new[] { "manufacturer_id" });
            DropIndex("dbo.CPU_Cooler", new[] { "manufacturer_id" });
            DropIndex("dbo.GPUs", new[] { "ram_type_id" });
            DropIndex("dbo.GPUs", new[] { "GPU_technology_id" });
            DropIndex("dbo.GPUs", new[] { "gpu_interface_id" });
            DropIndex("dbo.GPUs", new[] { "GPU_frame_Sync_id" });
            DropTable("dbo.M2Motherboard");
            DropTable("dbo.ManufacturerGPUs");
            DropTable("dbo.CPU_SocketCPU_Cooler");
            DropTable("dbo.ROM_Type");
            DropTable("dbo.ROM_form_factor");
            DropTable("dbo.ROMs");
            DropTable("dbo.PS_Rating");
            DropTable("dbo.PS_form_factor");
            DropTable("dbo.PS");
            DropTable("dbo.RAMs");
            DropTable("dbo.RAM_type");
            DropTable("dbo.Motherboard_form_factor");
            DropTable("dbo.Motherboard_chipset");
            DropTable("dbo.M2_form_factor");
            DropTable("dbo.M2");
            DropTable("dbo.Motherboards");
            DropTable("dbo.CPU_Serie");
            DropTable("dbo.CPU_Microarchitecture");
            DropTable("dbo.CPUs");
            DropTable("dbo.CPU_Socket");
            DropTable("dbo.CPU_Cooler");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.GPU_technology");
            DropTable("dbo.GPU_frame_sync");
            DropTable("dbo.GPUs");
            DropTable("dbo.Component_interface");
        }
    }
}
