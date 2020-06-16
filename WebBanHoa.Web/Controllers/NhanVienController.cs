﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebBanHoa.Web.Controllers
{
    using BLL;
    using DAL.Models;
    using Common.Req;
    using Common.Rsp;
    using WebBanHoa.Common.Rep;

    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        public NhanVienController()
        {
            _svc = new NhanVienSvc();
        }

        [HttpGet("lay-thong-tin-nhan-vien-theo-manv")]
        public IActionResult getNhanVienById([FromBody]SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.Read(req.Id);
            return Ok(res);
        }

        [HttpGet("lay-tat-ca-nhan-vien")]
        public IActionResult getAllNhanVienById()
        {
            var res = new SingleRsp();
            res.Data = _svc.All;
            return Ok(res);
        }

        [HttpGet("search_nhanvien")]
        public IActionResult SearchNhanVienCtrl([FromBody] SearchNhanVien req)
        {
            var res = new SingleRsp();
            var pros = _svc.SearchNhanVien(req.Keyword, req.Page, req.Size);
            res.Data = pros;

            return Ok(res);
        }

        [HttpPost("create_nhanvien")]
        public IActionResult CreateNhanVien([FromBody]NhanVienreq req)
        {
            var res = _svc.CreateNhanVien(req);
            return Ok(res);
        }

        [HttpPut("update_nhanvien")]
        public IActionResult UpdateNhanVien([FromBody]NhanVienreq req)
        {
            var res = _svc.UpdateNhanVien(req);
            return Ok(res);
        }


        private readonly NhanVienSvc _svc;
    }
}