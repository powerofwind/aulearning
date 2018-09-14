using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace demoapi.Controllers {
        [Route ("api/[controller]/[action]")]
        [ApiController]
        public class ValuesController : ControllerBase {
            //GET api/values
            // [HttpGet]
            // public booklist Get () {
            //     return new booklist {
            //         name = "doraemon",
            //             id = "001",
            //             slot = "a1",
            //             total = 10
            //     };
            // }

            [HttpGet ("{booklistCount}")]
            public ActionResult<IEnumerable<booklist>> Getbooklist (int booklistCount) {
            
                var booklists = new List<booklist> ();

                int count = 1;
                while (count <= booklistCount) {
                    var result = new booklist {
           
                    name = "tatae999" + count,
                    id = "b001" + count,
                    slot = "A1" + count,
                    total = count,

                    };
                    booklists.Add (result);
                    count++;

                }

                return booklists;
            }

            // [HttpGet ("{booklistCount}")]
            // public ActionResult<IEnumerable<booklist>> Getbooklist (int booklistCount) {
            //     var a = new List<booklist> ();

            //     int count = 1;
            //     while (count <= booklistCount) 
            //     {

            //       var result = new booklist 
            //       {
            //             name = "Conan",
            //             id = "001",
            //             slot = "a1",
            //             total = 10
            //       };
            //             a.Add (result);
            //             count++;
            //     }      

            //         return a;
                

            

            // }




            //     [HttpGet ("{name}")]
            //     public ActionResult<string> Getname (string name) {
            //         return "Hello  " + name;

            //     }

            //     // [HttpGet ("{name}")]
            //     // public string Get (string name)
            //     // {
            //     //     return "Hello  "  +  name;
            //     // }

            //     [HttpGet ("{total}")]
            //     public string Gettotal (int total) {
            //         return "Hi" + total;
            //     }

            //     [HttpGet ("{pasosword}")]
            //     public int password (int pasosword) {
            //         return pasosword;
            //     }

            //     [HttpGet ("{telephone}")]
            //     public string telephonenumber (int telephone) {
            //         return "your number is " + telephone;
            //     }
            }

        }