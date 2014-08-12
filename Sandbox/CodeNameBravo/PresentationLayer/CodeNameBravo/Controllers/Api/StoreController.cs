using System.Web.Http;
using CodeNameBravo.Domain.Entities.Stores;
using CodeNameBravo.Domain.Interfaces.Stores;

namespace CodeNameBravo.Web.Controllers.Api
{
    public class StoreController : ApiController
    {
        private IStoreDomainService _service;

        public StoreController(IStoreDomainService storeService)
        {
            _service = storeService;
        }

        // GET api/<controller>
        public IHttpActionResult Get([FromUri]int id)
        {
            return Ok(_service.GetStore(id));
        }

        // GET api/<controller>/5
        public IHttpActionResult Get()
        {
            return Ok(_service.GetStores());
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Store value)
        {
            _service.InsertStore(value);
            return Ok();
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]Store value)
        {
            _service.UpdateStore(value);
            return Ok();
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            _service.DeleteStore(id);
            return Ok();
        }
    }
}
