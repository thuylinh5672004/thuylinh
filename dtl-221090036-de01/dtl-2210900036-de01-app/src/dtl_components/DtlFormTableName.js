import axios from '../dtl_apis/dtl-2210900036';
import React, { useEffect, useState } from 'react';

export default function DtlFormTableName({ renderDtltableName, onEdit }) {
    const [dtlId, setDtlId] = useState(renderDtltableName.dtlId);
    const [dtlTbName, setDtlTbName] = useState(renderDtltableName.dtlTbName);
    const [dtlTbEmail, setDtlTbEmail] = useState(renderDtltableName.dtlTbEmail);
    const [dtlTbPhone, setDtlTbPhone] = useState(renderDtltableName.dtlTbPhone);
    const [dtlTbStatus, setDtlTbStatus] = useState(renderDtltableName.dtlTbStatus);

    useEffect(() => {
        setDtlId(renderDtltableName.dtlId);
        setDtlTbName(renderDtltableName.dtlTbName);
        setDtlTbEmail(renderDtltableName.dtlTbEmail);
        setDtlTbPhone(renderDtltableName.dtlTbPhone);
        setDtlTbStatus(renderDtltableName.dtlTbStatus);
    }, [renderDtltableName]);

    const dtlHandleSubmit = async (dtlEvent) => {
        dtlEvent.preventDefault(); // Ngăn chặn hành vi mặc định của form
        const dtlObjTableName = {
            "dtlTbName": dtlTbName,
            "dtlTbEmail": dtlTbEmail,
            "dtlTbPhone": dtlTbPhone,
            "dtlTbStatus": dtlTbStatus,
            "dtlId": dtlId
        };
        console.log(dtlObjTableName);
        // Thêm vào dữ liệu trong API
        await axios.put("dtlTableName/" + dtlObjTableName.dtlId, dtlObjTableName);
        onEdit();
    };

    return (
        <div>
            <h2>Form xử lý dữ liệu thêm mới</h2>
            <form>
                <div className="input-group mb-3">
                    <span className="input-group-text" id="dtlId">dtlId</span>
                    <input type="text" className="form-control" placeholder="dtlId"
                        name='dtlId'
                        value={dtlId}
                        onChange={(dtlEv) => setDtlId(dtlEv.target.value)}
                        aria-label="dtlId" aria-describedby="dtlId" />
                </div>
                <div className="input-group mb-3">
                    <span className="input-group-text" id="dtlTbName">dtlTbName</span>
                    <input type="text" className="form-control" placeholder="dtlTbName"
                        name='dtlTbName'
                        value={dtlTbName}
                        onChange={(dtlEv) => setDtlTbName(dtlEv.target.value)}
                        aria-label="dtlTbName" aria-describedby="dtlTbName" />
                </div>
                <div className="input-group mb-3">
                    <span className="input-group-text" id="dtlTbEmail">dtlTbEmail</span>
                    <input type="text" className="form-control" placeholder="thuy linh@gmail.com"
                        name='dtlTbEmail'
                        value={dtlTbEmail}
                        onChange={(dtlEv) => setDtlTbEmail(dtlEv.target.value)}
                        aria-label="dtlTbEmail" aria-describedby="dtlTbEmail" />
                </div>
                <div className="input-group mb-3">
                    <span className="input-group-text" id="dtlTbPhone">dtlTbPhone</span>
                    <input type="text" className="form-control" placeholder="0987654323"
                        name='dtlTbPhone'
                        value={dtlTbPhone}
                        onChange={(dtlEv) => setDtlTbPhone(dtlEv.target.value)}
                        aria-label="dtlTbPhone"
                        aria-describedby="dtlTbPhone" />
                </div>
                <div className="input-group mb-3">
                    <span className="input-group-text" id="dtlTbStatus">dtlTbStatus</span>
                    <select id='dtlTbStatus' className='form-control'
                        name='dtlTbStatus'
                        value={dtlTbStatus}
                        onChange={(dtlEv) => setDtlTbStatus(dtlEv.target.value)}>
                        <option value={true}>Active</option>
                        <option value={false}>Non-Active</option>
                    </select>
                </div>
                <button className='btn btn-primary' name='btnDtlSave' onClick={dtlHandleSubmit}>Dtl:save</button>
            </form>
        </div>
    );
}
