using GerenciadordeVendas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadordeVendas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StringController : ControllerBase
    {
        [HttpGet]
        [Route("s")]
        public async Task<ActionResult<IEnumerable<Solution>>> solve()
        {
            List<Solution> listaSolution = new List<Solution>();
            Solution solution = new Solution();
            solution.String = "blabla";
            solution.tempototal = "10";
            solution.vogal = "e";
            listaSolution.Add(solution);
            return listaSolution;
            //return Ok(new { message = listaSolution });
        }
        [HttpPost]
        [Route("p")]
        public async Task<ActionResult<IEnumerable<Solution>>> solvePost([FromBody] requestString String)
        {
            if (ModelState.IsValid)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                func f = new func();
                Solution solution = new Solution();
                String str = String.String;
                solution.String = String.String;
                for (int i = 2; i < str.Length; i++)
                {
                        if (f.isVogal(str[i]) == true)
                        {
                            if (f.isVogal(str[i - 1]) == false)
                            {
                                if (f.isVogal(str[i - 2]) == true)
                                {
                                    if (str[i - 2] != str[i])
                                    {
                                        solution.vogal = str[i].ToString();
                                        stopWatch.Stop();
                                        solution.tempototal = stopWatch.Elapsed.ToString();
                                        return Ok(new { message = solution });
                                    }
                                }
                            }
                        }
                    }
                    solution.tempototal = "0";
                    solution.vogal = "Não achou";
                    return Ok(new { message = solution });
                }
            
            return BadRequest(ModelState);
        }
    }
}
