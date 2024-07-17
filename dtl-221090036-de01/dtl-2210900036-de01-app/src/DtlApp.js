import React, { useEffect, useState } from 'react';
import DtlListTableName from './dtl_components/DtlListTableName';

import DtlFormTableName from './dtl_components/DtlFormTableName';
import axios from './dtl_apis/dtl-2210900036';

export default function DtlApp() {
    // Đọc dữ liệu từ API
    const [dtlListTableName, setDtlListTableName] = useState([]);
    const [dtlTableName, setDtlTableName] = useState({
        "dtlTbName": "đào thị thùy linh",
        "dtlTbEmail": "thuylinh@gmail.com",
        "dtlTbPhone": "0987654323",
        "dtlTbStatus": true,
        "dtlId": "2210900036"
    });

    // Hàm lấy dữ liệu từ API
    const dtlGetTableName = async () => {
      try {
        let dtlResp = await axios.get("dtlTableName");
        console.log(" App list:",dtlResp.data);
        setDtlListTableName(dtlResp.data);
      } 
    catch (error) {
        console.error("Lỗi khi lấy dữ liệu: ", error);
    }
           
    };

    useEffect(() => {
        dtlGetTableName();
    }, []);

    // Hàm xóa
    const dtlHanldeDelete = async (dtlId) => {
        try {
            await axios.delete("dtlTableName/" + dtlId);
            dtlGetTableName(); // Cập nhật lại danh sách sau khi xóa
        } catch (error) {
            console.error("Error deleting data: ", error);
        }
    };

    // Hàm chỉnh sửa
    const dtlHanleEdit = (dtlObjTableName) => {
        setDtlTableName(dtlObjTableName);
    };

    const dtlHandelEdit = () => {
        dtlGetTableName();
    };

    return (
        <div className='container border my-3'>
            <h1>Bài thi đánh giá hết học phần - Đào Thị Thùy Linh: 2210900036</h1>
            <hr/>
            <DtlListTableName 
                renderDtlListTableName={dtlListTableName} 
                onDtlDelete={dtlHanldeDelete} 
                onDtlEdit={dtlHanleEdit} 
            />
            <hr/>
            <DtlFormTableName 
                renderDtltableName={dtlTableName} 
                onEdit={dtlHandelEdit} 
            />
        </div>
    );
}
