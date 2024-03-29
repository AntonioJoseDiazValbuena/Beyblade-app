﻿using Beyblade.Entities;
using Beyblade.Entities.DTO;
using Beyblade.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beyblade.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BeybladeManagementController : ControllerBase
    {
        private readonly IBeybladeServices _beybladeServices;

        public BeybladeManagementController(IBeybladeServices beybladeServices)
        {
            _beybladeServices = beybladeServices;
        }

        [HttpPost]
        [Route("Battle")]
        public object Battle(BeybladeBattle beybladeBattle)
        {
            string response = _beybladeServices.StartBattle(beybladeBattle.FirstBeyblade, beybladeBattle.SecondBeyblade);
            return new {
                response
            };
        }

        [HttpGet]
        [Route("Layers")]
        public List<Layer> ObtainLayers()
        {
            return _beybladeServices.ObtainLayers();
        }

        [HttpPost]
        [Route("Layer")]
        public void RegisterLayer(Layer layer)
        {
            _beybladeServices.RegisterLayer(layer);
        }

        [HttpDelete]
        [Route("Layer/{layerId}")]
        public void DeleteLayer(int layerId)
        {
            _beybladeServices.DeleteLayer(layerId);
        }

        [HttpGet]
        [Route("Disks")]
        public List<Disk> ObtainDisks()
        {
            return _beybladeServices.ObtainDisks();
        }

        [HttpPost]
        [Route("Disk")]
        public void RegisterDisk(Disk disk)
        {
            _beybladeServices.RegisterDisk(disk);
        }

        [HttpDelete]
        [Route("Disk/{diskId}")]
        public void DeleteDisk(int diskId)
        {
            _beybladeServices.DeleteDisk(diskId);
        }

        /*[HttpGet]
        [Route("Frames")]
        public List<Frame> ObtainFrames()
        {
            return _beybladeServices.ObtainFrames();
        }

        [HttpPost]
        [Route("Frame")]
        public void RegisterFrame(Frame frame)
        {
            _beybladeServices.RegisterFrame(frame);
        }*/

        [HttpGet]
        [Route("Drivers")]
        public List<Driver> ObtainDrivers ()
        {
            return _beybladeServices.ObtainDrivers();
        }

        [HttpPost]
        [Route("Driver")]
        public void RegisterDriver(Driver driver)
        {
            _beybladeServices.RegisterDriver(driver);
        }

        [HttpDelete]
        [Route("Driver/{driverId}")]
        public void DeleteDriver(int driverId)
        {
            _beybladeServices.DeleteDriver(driverId);
        }
    }
}
