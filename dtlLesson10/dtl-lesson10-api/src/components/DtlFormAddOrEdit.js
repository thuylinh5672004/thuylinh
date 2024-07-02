import axios from '../api/dtlApi'
import React, { useEffect, useState } from 'react'

export default function DtlFormAddOrEdit({onDtlClose, onDtlSubmitForm, renderUsers}) {

    console.log(renderUsers);
    const [dtlId, setDtlId] = useState(0);
    const [dtlUserName, setDtlUserName] = useState("");
    const [dtlPassword, setDtlPassword] = useState("");
    const [dtlEmail, setDtlEmail] = useState("");
    const [dtlPhone, setDtlPhone] = useState("");

    useEffect(()=>{
        setDtlId(renderUsers.id)
        setDtlUserName(renderUsers.UserName)
        setDtlPassword(renderUsers.Password)
        setDtlEmail(renderUsers.Email)
        setDtlPhone(renderUsers.Phone)
    },[renderUsers])


    const dtlHandleClose = ()=>{
        onDtlClose(false);
    }

    const dtlHandleSubmit= async (event)=>{
        event.preventDefault();
        console.log(dtlId,dtlUserName,dtlPassword,dtlEmail,dtlPhone);
        // post -> api
        let dtlObjUser = {
            UserName: dtlUserName,
            Password: dtlPassword,
            Email: dtlEmail,
            Phone: dtlPhone,
            id: dtlId
        }
        const dtlRes = await axios.post("dtlUsers",dtlObjUser);

        onDtlSubmitForm(false)

    }
  return (
    <div className=''>
      <form>
        <div className="input-group mb-3">
            <span className="input-group-text" id="id">Id</span>
            <input type="text" class="form-control" 
                name='id' value={dtlId} onChange={(ev)=>setDtlId(ev.target.value)}
                placeholder="id" aria-label="id" aria-describedby="id"/>
        </div>
        <div className="input-group mb-3">
            <span className="input-group-text" id="UserName">UserName</span>
            <input type="text" class="form-control" 
                name='UserName' value={dtlUserName} onChange={(ev)=>setDtlUserName(ev.target.value)}
                placeholder="UserName" aria-label="UserName" aria-describedby="UserName"/>
        </div>
        <div className="input-group mb-3">
            <span className="input-group-text" id="Password">Password</span>
            <input type="password" class="form-control" 
                name='Password' value={dtlPassword} onChange={(ev)=>setDtlPassword(ev.target.value)}
                placeholder="Password" aria-label="Password" aria-describedby="Password"/>
        </div>
        <div className="input-group mb-3">
            <span className="input-group-text" id="Email">Email</span>
            <input type="email" class="form-control" 
                name='Email' value={dtlEmail} onChange={(ev)=>setDtlEmail(ev.target.value)}
                placeholder="Email" aria-label="Email" aria-describedby="Email"/>
        </div>
        
        <div className="input-group mb-3">
            <span className="input-group-text" id="Phone">Phone</span>
            <input type="number" class="form-control" 
                name='Phone' value={dtlPhone} onChange={(ev)=>setDtlPhone(ev.target.value)}
                placeholder="Phone" aria-label="Phone" aria-describedby="Phone"/>
        </div>
        <button className='btn btn-primary' name='btnDtlSave' onClick={(ev)=>dtlHandleSubmit(ev)}>Ghi lại</button>
        <button className='btn btn-danger' onClick={dtlHandleClose}>Đóng</button>
      </form>
    </div>
  )
}
