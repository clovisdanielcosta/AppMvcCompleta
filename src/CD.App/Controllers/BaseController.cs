﻿using CD.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CD.App.Controllers
{
    public class BaseController : Controller
    {
        private readonly INotificador _notificador;

        public BaseController(INotificador notificador)
        {
            _notificador = notificador;
        }
    }
}