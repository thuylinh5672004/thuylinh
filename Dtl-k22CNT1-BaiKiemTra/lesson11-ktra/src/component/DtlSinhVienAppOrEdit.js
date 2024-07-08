import axios from '../api/DtlApi'
import React, { useEffect, useState } from 'react'

export default function DtlSinhVienAppOrEdit({onDtlClose, onDtlSubmitForm, renderUsers}) {

    console.log(renderUsers);
    const [dtlMaSV, setDtlMaSV] = useState(0);
    const [dtlHoSV, setDtlHoSV] = useState("");
    const [dtlTenSV, setDtlTenSV] = useState("");
    const [dtlPhai, setDtlPhai] = useState("");
    const [dtlNgaysinh, setDtlNgaysinh] = useState("");
    const [dtlNoisinh, setDtlNoisinh] = useState("");
    const [dtlMaKH, setDtlMaKH] = useState("");
    const [dtlHocbong, setDtlHocbong] = useState("");
    const [dtlDiemtrungbinh, setDtlDiemtrungbinh] = useState("");

    useEffect(()=>{
        setDtlMaSV(renderUsers.MaSV)
        setDtlHoSV(renderUsers.HoSV)
        setDtlTenSV(renderUsers.TenSV)
        setDtlPhai(renderUsers.Phai)
        setDtlNgaysinh(renderUsers.Ngaysinh)
        setDtlNoisinh(renderUsers.Noisinh)
        setDtlMaKH(renderUsers.MaKH)
        setDtlHocbong(renderUsers.Hocbong)
        setDtlDiemtrungbinh(renderUsers.Diemtrungbinh)
    },[renderUsers])


    const dtlHandleClose = ()=>{
        onDtlClose(false);
    }

    const dtlHandleSubmit= async (event)=>{
        event.preventDefault();
        console.log(dtlMaSV,dtlHoSV,dtlTenSV,dtlPhai,dtlNgaysinh,dtlNoisinh,dtlMaKH,dtlHocbong,dtlDiemtrungbinh);
        // post -> api
        let dtlObjUser = {
            DtlMaSV: dtlMaSV,
            DtlHoSV: dtlHoSV, 
            DtlTenSV:dtlTenSV ,
            DtlPhai: dtlPhai,
            DtlNgaysinh: dtlNgaysinh,
            DtlNoisinh: dtlNoisinh ,
            DtlMaKH: dtlMaKH,
            DtlHocbong : dtlHocbong,
            DtlDiemtrungbinh: dtlDiemtrungbinh,
        

            
        }
        const dtlRes = await axios.post("dtlUsers",dtlObjUser);

        onDtlSubmitForm(false)

    }
  return (
    <div className=''>
      <form>
        <div className="input-group mb-3">
            <span className="input-group-text" id="id">MaSV</span>
            <input type="text" class="form-control" 
                name='MaSV' value={dtlMaSV} onChange={(ev)=>setDtlMaSV(ev.target.value)}
                placeholder="MaSV" aria-label="MaSV" aria-describedby="MaSV"/>
        </div>
        <div className="input-group mb-3">
            <span className="input-group-text" id="HoSV">HoSV</span>
            <input type="text" class="form-control" 
                name='HoSV' value={dtlHoSV} onChange={(ev)=>setDtlHoSV(ev.target.value)}
                placeholder="HoSV" aria-label="HoSV" aria-describedby="HoSV"/>
        </div>
        <div className="input-group mb-3">
            <span className="input-group-text" id="TenSV">TenSV</span>
            <input type="TenSV" class="form-control" 
                name='TenSV' value={dtlTenSV} onChange={(ev)=>setDtlTenSV(ev.target.value)}
                placeholder="TenSV" aria-label="TenSV" aria-describedby="TenSV"/>
        </div>
        <div className="input-group mb-3">
            <span className="input-group-text" id="Phai">Phai</span>
            <input type="Phai" class="form-control" 
                name='Phai' value={DtlSinhVienAppOrEdit} onChange={(ev)=>setDtlPhai(ev.target.value)}
                placeholder="Phai" aria-label="Phai" aria-describedby="Phai"/>
        </div>
        
        <div className="input-group mb-3">
            <span className="input-group-text" id="Ngaysinh">Ngaysinh</span>
            <input type="date" class="form-control" 
                name='Ngaysinh' value={dtlNgaysinh} onChange={(ev)=>setDtlNgaysinh(ev.target.value)}
                placeholder="Ngaysinh" aria-label="Ngaysinh" aria-describedby="Ngaysinh"/>
        </div>
        <div className="input-group mb-3">
            <span className="input-group-text" id="Noisinh">Noisinh</span>
            <input type="text" class="form-control" 
                name='Noisinh' value={dtlNoisinh} onChange={(ev)=>setDtlNoisinh(ev.target.value)}
                placeholder="Noisinh" aria-label="Noisinh" aria-describedby="Noisinh"/>
            
        </div> 
        <div className="input-group mb-3">
            <span className="input-group-text" id="MaKH">MaKH</span>
            <input type="text" class="form-control" 
                name='MaKH' value={dtlMaKH} onChange={(ev)=>setDtlMaKH(ev.target.value)}
                placeholder="MaKH" aria-label="MaKH" aria-describedby="MaKH"/>
            
        </div> 
        <div className="input-group mb-3">
            <span className="input-group-text" id="Hocbong">Hocbong</span>
            <input type="text" class="form-control" 
                name='Hocbong' value={dtlHocbong} onChange={(ev)=>setDtlNoisinh(ev.target.value)}
                placeholder="Hocbong" aria-label="Hocbong" aria-describedby="Hocbong"/>
        </div> <div className="input-group mb-3">
            <span className="input-group-text" id="DiemTrungBinh">Diem TB</span>
            <input type="number" class="form-control" 
                name='Diemtrungbinh' value={dtlDiemtrungbinh} onChange={(ev)=>setDtlDiemtrungbinh(ev.target.value)}
                placeholder="Diemtrungbinh" aria-label="Diemrunginh" aria-describedby="Diemtrungbinh"/>
        </div>
        <button className='btn btn-primary' name='btnDtlSave' onClick={(ev)=>dtlHandleSubmit(ev)}>Ghi lại</button>
        <button className='btn btn-danger' onClick={dtlHandleClose}>Đóng</button>
      </form>
    </div>
  )
}
