namespace Homer_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<COMUNA> COMUNA { get; set; }
        public virtual DbSet<CONDICIONES_COMERCIALES> CONDICIONES_COMERCIALES { get; set; }
        public virtual DbSet<CONTACTO> CONTACTO { get; set; }
        public virtual DbSet<COTIZACION> COTIZACION { get; set; }
        public virtual DbSet<COTIZACION_DETALLE> COTIZACION_DETALLE { get; set; }
        public virtual DbSet<EMPRESA> EMPRESA { get; set; }
        public virtual DbSet<ESTADOS> ESTADOS { get; set; }
        public virtual DbSet<FLUJOS> FLUJOS { get; set; }
        public virtual DbSet<FLUJOS_NIVELES> FLUJOS_NIVELES { get; set; }
        public virtual DbSet<FLUJOS_NIVELES_USUARIOS> FLUJOS_NIVELES_USUARIOS { get; set; }
        public virtual DbSet<PERFILES> PERFILES { get; set; }
        public virtual DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual DbSet<RELA_SERVICIOS_CONDICIONESC> RELA_SERVICIOS_CONDICIONESC { get; set; }
        public virtual DbSet<SERVICIOS> SERVICIOS { get; set; }
        public virtual DbSet<SOLICITUD_NIVEL_ADJUNTO> SOLICITUD_NIVEL_ADJUNTO { get; set; }
        public virtual DbSet<SOLICITUD_NIVELES> SOLICITUD_NIVELES { get; set; }
        public virtual DbSet<SOLICITUDES> SOLICITUDES { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TIPO_PERFIL> TIPO_PERFIL { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CLIENTE_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CLIENTE_RUT)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CLIENTE_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CLIENTE_DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CLIENTE_COMUNA)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CLIENTE_REGION)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CLIENTE_SITIOWEB)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CLIENTE_REPRESENTANTE_LEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CLIENTE_RUT_REPRESENTANTE_LEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CLIENTE_CARGO_REPRESENTANTE_LEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CLIENTE_TIPO_EMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CLIENTE_TIPO_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .HasMany(e => e.CONDICIONES_COMERCIALES)
                .WithRequired(e => e.CLIENTES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES>()
                .HasMany(e => e.CONTACTO)
                .WithOptional(e => e.CLIENTES)
                .HasForeignKey(e => e.CON_IDCLIENTE);

            modelBuilder.Entity<CLIENTES>()
                .HasMany(e => e.COTIZACION)
                .WithRequired(e => e.CLIENTES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMUNA>()
                .Property(e => e.COMUNA_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<COMUNA>()
                .Property(e => e.COMUNA_REGION)
                .IsUnicode(false);

            modelBuilder.Entity<COMUNA>()
                .Property(e => e.COMUNA_CREACION)
                .IsUnicode(false);

            modelBuilder.Entity<CONDICIONES_COMERCIALES>()
                .HasMany(e => e.RELA_SERVICIOS_CONDICIONESC)
                .WithRequired(e => e.CONDICIONES_COMERCIALES)
                .HasForeignKey(e => e.ID_CONDICIONES_COMERCIALES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTACTO>()
                .Property(e => e.CON_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACTO>()
                .Property(e => e.CON_APATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACTO>()
                .Property(e => e.CON_AMATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACTO>()
                .Property(e => e.CON_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACTO>()
                .Property(e => e.CON_CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACTO>()
                .Property(e => e.CON_SUCURSAL)
                .IsUnicode(false);

            modelBuilder.Entity<CONTACTO>()
                .Property(e => e.CON_RUT_SUC)
                .IsUnicode(false);

            modelBuilder.Entity<COTIZACION>()
                .Property(e => e.numero)
                .IsUnicode(false);

            modelBuilder.Entity<COTIZACION>()
                .HasMany(e => e.COTIZACION_DETALLE)
                .WithRequired(e => e.COTIZACION)
                .HasForeignKey(e => e.id_cotizacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COTIZACION>()
                .HasMany(e => e.SOLICITUDES)
                .WithRequired(e => e.COTIZACION)
                .HasForeignKey(e => e.id_cotizacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COTIZACION_DETALLE>()
                .Property(e => e.cod_articulo)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.rut)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.CLIENTES)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.FLUJOS)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.PERFILES)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTADOS>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADOS>()
                .HasMany(e => e.CLIENTES)
                .WithOptional(e => e.ESTADOS)
                .HasForeignKey(e => e.CLIENTE_ESTADO);

            modelBuilder.Entity<ESTADOS>()
                .HasMany(e => e.CONTACTO)
                .WithOptional(e => e.ESTADOS)
                .HasForeignKey(e => e.CON_ESTADO);

            modelBuilder.Entity<ESTADOS>()
                .HasMany(e => e.COTIZACION)
                .WithRequired(e => e.ESTADOS)
                .HasForeignKey(e => e.id_estado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTADOS>()
                .HasMany(e => e.SOLICITUDES)
                .WithRequired(e => e.ESTADOS)
                .HasForeignKey(e => e.id_estado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FLUJOS>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<FLUJOS>()
                .HasMany(e => e.FLUJOS_NIVELES)
                .WithRequired(e => e.FLUJOS)
                .HasForeignKey(e => e.id_flujo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FLUJOS>()
                .HasMany(e => e.SOLICITUDES)
                .WithRequired(e => e.FLUJOS)
                .HasForeignKey(e => e.id_flujo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FLUJOS_NIVELES>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<FLUJOS_NIVELES>()
                .HasMany(e => e.FLUJOS_NIVELES_USUARIOS)
                .WithRequired(e => e.FLUJOS_NIVELES)
                .HasForeignKey(e => e.id_flujonivel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FLUJOS_NIVELES>()
                .HasMany(e => e.SOLICITUD_NIVELES)
                .WithRequired(e => e.FLUJOS_NIVELES)
                .HasForeignKey(e => e.id_flujonivel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERFILES>()
                .Property(e => e.PER_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PERFILES>()
                .HasMany(e => e.USUARIOS)
                .WithOptional(e => e.PERFILES)
                .HasForeignKey(e => e.USU_IDPERFIL);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.PROV_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.PROV_RUT)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.PROV_DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIOS>()
                .HasMany(e => e.RELA_SERVICIOS_CONDICIONESC)
                .WithRequired(e => e.SERVICIOS)
                .HasForeignKey(e => e.ID_SERVICIOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SOLICITUD_NIVEL_ADJUNTO>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_NIVEL_ADJUNTO>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_NIVEL_ADJUNTO>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_NIVEL_ADJUNTO>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_NIVELES>()
                .Property(e => e.accion)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_NIVELES>()
                .Property(e => e.observacion)
                .IsUnicode(false);

            modelBuilder.Entity<SOLICITUD_NIVELES>()
                .HasMany(e => e.SOLICITUD_NIVEL_ADJUNTO)
                .WithRequired(e => e.SOLICITUD_NIVELES)
                .HasForeignKey(e => e.id_solnivel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SOLICITUDES>()
                .HasMany(e => e.SOLICITUD_NIVELES)
                .WithRequired(e => e.SOLICITUDES)
                .HasForeignKey(e => e.id_solicitud)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_PERFIL>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PERFIL>()
                .Property(e => e.codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PERFIL>()
                .HasMany(e => e.PERFILES)
                .WithOptional(e => e.TIPO_PERFIL)
                .HasForeignKey(e => e.PER_IDTIPOPERFIL);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.USU_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.USU_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .HasMany(e => e.SOLICITUDES)
                .WithRequired(e => e.USUARIOS)
                .HasForeignKey(e => e.id_usuarioInicio)
                .WillCascadeOnDelete(false);
        }
    }
}
