using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HolaMundo.Models;

namespace HolaMundo.Controllers;

public class ContactoController : Controller {

    public IActionResult index(){

        return View();
    }



}