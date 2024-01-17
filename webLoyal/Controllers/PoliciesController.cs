﻿using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class PoliciesController : BaseController
    {
        private readonly IPolicies _request;
        private readonly IAgents _requestAgente;
        public PoliciesController(IPolicies request, IAgents requestAgente)
        {
            _request = request;
            _requestAgente = requestAgente;
        }
        public async Task<IActionResult> Index()
        {
            var x = await _request.GetAll();
            return View(x.ToList());
        }
        [HttpGet]
        [Route("Policies/Detail/{codigoSolicitud}")]
        public async Task<IActionResult> Detail(int codigoSolicitud) 
        { 
            var model = await _request.GetByCode(codigoSolicitud);
            return View(model); 
        }

        public async Task<IActionResult> Renewal()
        {
            var x = await _request.GetFiguresRenewal();
            return View(x.ToList());
        }

        public IActionResult Cancellation()
        {
            return PartialView("_Cancellation");
        }        
        public IActionResult ChangeOfPlan()
        {
            return PartialView("_Cancellation");
        }        
        public IActionResult Modification()
        {
            return PartialView("_Cancellation");
        }        
        public IActionResult RecordNote()
        {
            return PartialView("_Cancellation");
        }        
        public IActionResult ModifyTaker()
        {
            return PartialView("_Cancellation");
        }        
        public IActionResult AddDocuments()
        {
            return PartialView("_Cancellation");
        }
        public async Task<IActionResult> RecodeAgent(int CodigoCertificado)
        {
            IQueryable<ListaAgentesModel> listaDeModelos = await _requestAgente.ListAgentByState("01"); 
            ViewBag.ListaDeModelos = listaDeModelos.ToList();
            ViewBag.CodigoCertificado = CodigoCertificado;

            var model =await _requestAgente.ListAgentByState("01");
            return PartialView("_RecodeAgent");
        }
        [HttpPost]
        public IActionResult RecodeAgent(RecodeAgentModel model)
        {
            var x = _requestAgente.ListAgentByState("01");
            return Json(new
            {
                success = true,
                title = Resources.language.Resources.Success,
                text = Resources.language.Resources.WelcomeMessage.ToString(),
                icon = "success",
                timer = 2000
            });
        }
    }
}
