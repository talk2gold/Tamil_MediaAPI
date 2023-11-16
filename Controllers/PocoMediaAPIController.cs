using MediaAPI.Data;
using MediaAPI.Model;
using MediaAPI.Model.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MediaAPI.Controllers
{
    //Type of Api call
    //DELETE --Delete Record
	public class PocoMediaAPIController : ControllerBase
	{
        [Route("api/PocoMediaAPI")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<PocoMediaDTO>> getMedias()
        {
            return Ok(MediaStore.mediaList);
        }
        
        [HttpGet("id:int", Name="getMedia")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<PocoMediaDTO> getMedia(int id) 
        {
            // Select * from mediaList x where x.Id = id and rownum <= 1
            if(id == 0)
            {
                return BadRequest();
            }

            var pocoMedia = MediaStore.mediaList.FirstOrDefault(x => x.Id == id);

            if(pocoMedia == null)
            {
                return NotFound();
            }
            return Ok(pocoMedia);
        }

        { 
            //if (media == null)
            //{
            //    return BadRequest();
            //}

            //if (media.Id > 0)
            //{
            //    return BadRequest();
            //    // return StatusCode(StatusCodes.Status500InternalServerError);
            //}
            media.Id = 11;
            MediaStore.mediaList.Add(media);
            return CreatedAtRoute("getMedia", new { id = media.Id }, media);
        }


    }
}
