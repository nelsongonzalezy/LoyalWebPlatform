namespace core.Service
{
    public class MenuService : IMenu
    {
        public async Task<IQueryable<MenuModel>> GetByUser()
        {
            var menu = new List<MenuModel>();
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 2   ,OptionTypeCode = "03 ", NameOption = "Dashboard CEO ", Order = 1, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 24  ,OptionTypeCode = "02 ", NameOption = "Affinity ", Order = 1, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 31  ,OptionTypeCode = "02 ", NameOption = "Affinity ", Order = 1, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 5   ,OptionTypeCode = "01 ", NameOption = "Menu Principal ", Order = 2, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 6   ,OptionTypeCode = "02 ", NameOption = "Mantenimiento Agentes ", Order = 2, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 14  ,OptionTypeCode = "01 ", NameOption = "Menu Consulta ", Order = 2, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 36  ,OptionTypeCode = "02 ", NameOption = "Certificaciones ", Order = 3, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 11  ,OptionTypeCode = "02 ", NameOption = "Pagos ", Order = 4, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 10  ,OptionTypeCode = "02 ", NameOption = "Comisiones ", Order = 5, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 30  ,OptionTypeCode = "02 ", NameOption = "Control ", Order = 6, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 23  ,OptionTypeCode = "02 ", NameOption = "Consulta Campañas ", Order = 7, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 27  ,OptionTypeCode = "02 ", NameOption = "Consulta de Cotizaciones ", Order = 8, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 7   ,OptionTypeCode = "02 ", NameOption = "Cotizador ", Order = 9, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 34  ,OptionTypeCode = "02 ", NameOption = "Listado Personas ", Order = 10, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 26  ,OptionTypeCode = "02 ", NameOption = "Ingresos/Egresos ", Order = 11, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 32  ,OptionTypeCode = "02 ", NameOption = "Maestros ", Order = 12, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 22  ,OptionTypeCode = "02 ", NameOption = "Consulta Mapas ", Order = 13, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 29  ,OptionTypeCode = "02 ", NameOption = "Personal ", Order = 14, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 21  ,OptionTypeCode = "02 ", NameOption = "Consulta Polizas ", Order = 15, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 55  ,OptionTypeCode = "02 ", NameOption = "Procesos ", Order = 16, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 13  ,OptionTypeCode = "02 ", NameOption = "Proveedores ", Order = 17, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 56  ,OptionTypeCode = "02 ", NameOption = "Información Cobranzas ", Order = 17, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 25  ,OptionTypeCode = "02 ", NameOption = "Tareas por Persona ", Order = 18, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 35  ,OptionTypeCode = "02 ", NameOption = "Coaseguros ", Order = 19, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 19  ,OptionTypeCode = "02 ", NameOption = "Consulta Reclamos ", Order = 20, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 9   ,OptionTypeCode = "02 ", NameOption = "Renovaciones Externas ", Order = 21, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 12  ,OptionTypeCode = "02 ", NameOption = "Renovaciones ", Order = 22, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 8   ,OptionTypeCode = "02 ", NameOption = "Registrar RTU ", Order = 23, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 33  ,OptionTypeCode = "02 ", NameOption = "Seguridad ", Order = 24, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 38  ,OptionTypeCode = "02 ", NameOption = "Taxes ", Order = 25, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 37  ,OptionTypeCode = "02 ", NameOption = "Tickets ", Order = 26, Url = "/home/InConstruction "});
            menu.Add(new MenuModel { UserCode = 776, OptionCode = 28  ,OptionTypeCode = "02 ", NameOption = "Usuarios ", Order = 27, Url = "/home/InConstruction "});

            return menu.AsQueryable();
        }
    }
}
