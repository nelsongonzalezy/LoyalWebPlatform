﻿namespace core.Service
{
    public class PoliciesServices : IPolicies
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;
        public PoliciesServices(IHttpServicesUnAuthorized unAuthorized)
        {
            this._unAuthorized = unAuthorized;
        }
        public async Task<IQueryable<CertificadosModel>> GetAll()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseRequestCertificadosModel>("api/v1/Certificados/ObtenerCertificados");
           
            
            return y.Content.AsQueryable();
        }       
        public async Task<IQueryable<CifraCertificadoEstadoModel>> GetAllStatus()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseRequestCifraSolicitudEstadoModel>("api/v1/Certificados/ObtenerCertificadosEstado");
            foreach (var item in y.Content)
            {
                item.Icon = "ri-shopping-bag-3-line";
            }

            return y.Content.AsQueryable();
        }        
        public async Task<IQueryable<CifraCertificadoProductoModel>> GetAllProduct()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseRequestCifraSolicitudProductoModel>("api/v1/Certificados/ObtenerCertificadosProducto");
            foreach (var item in y.Content)
            {
                if (item.CodigoProducto == 3)
                {
                    item.Color = "background-color:rgb(48,182,181)";
                    item.Img = "/assets/img/liberty.png";
                }
                if (item.CodigoProducto == 1)
                {
                    item.Color = "background-color:rgb(60,95,138)";
                    item.Img = "/assets/img/beyond.png";
                }
                if (item.CodigoProducto == 4)
                {
                    item.Color = "background-color:rgb(132,26,102)";
                    item.Img = "/assets/img/legacy.png";
                }
                if (item.CodigoProducto == 2)
                {
                    item.Color = "background-color:rgb(141,195,65)";
                    item.Img = "/assets/img/privilege.png";
                }

            }

            return y.Content.AsQueryable();
        }       
        public async Task<IQueryable<CifraCertificadosRenovacionesModel>> GetAllRenewal()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseCifraCertificadosRenovacionesModel>("api/v1/Certificados/ObtenerCifrasCertificadosRenvacion");
            return y.Content.AsQueryable();
        } 
        public async Task<IQueryable<CertificadosRenovacionModel>> GetFiguresRenewal()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseCertificadosRenovacionModel>("api/v1/Certificados/ObtenerCertificadosRenvacion");
            return y.Content.AsQueryable();
        }
        public async Task<VwSolcitudConsultaModel> GetByCode(int codigoSolicitud)
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseVwSolcitudConsultaModel>("api/v1/Certificados/ConsultaSolicitud?codigoSolicitud=" + codigoSolicitud);
            return y.Content;
        } 
        public async Task<IQueryable<VvCertificadosPorPaisModel>> GetpoliciesForCountry()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseRequestVvCertificadosPorPaisModel>("api/v1/Certificados/ConsultaCertificadosPorPais");
            return y.Content.AsQueryable();
        }
        public async Task<bool> RecodeAgent(RecodeAgentModel model)
        {
            return await _unAuthorized.PostUnAuthorizedAsync<RecodeAgentModel,bool>("api/v1/Certificados/RecodificarAgente", model);
        }
    }
}
