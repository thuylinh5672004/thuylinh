import './App.css';
import DtlSinhVienList from './component/DtlSinhVienList';
import axios from './api/DtlApi';
import { useEffect, useState } from 'react';
import DtlSinhVienAppOrEdit from './component/DtlSinhVienAppOrEdit';

function DtlApp() {
  
  const [dtlSinhVienList, setDtlSinhVienList] = useState([]);

  // Hàm để gọi API và lấy dữ liệu
  const dtlGetAllUsers = async () => {
    try {
      const dtlResponse = await axios.get("dtlUsers");
      console.log("Dữ liệu từ API:", dtlResponse.data);
      setDtlSinhVienList(dtlResponse.data);
    } catch (error) {
      console.error("Lỗi khi lấy dữ liệu:", error);
    }
  };

  // useEffect để gọi dtlGetAllUsers khi component được mount (tương đương componentDidMount)
  useEffect(() => {
    dtlGetAllUsers();
    console.log("state Data:",dtlSinhVienList);
    
  }, [])
  const [dtlSinhVienAppOrEdit, setDtlSinhVienAppOrEdit] = useState(false);
  const dtlInitUser = {
    DtlMaSV: "",
    DtlHoSV: "",
    DtlTenSV: "",
    DtlPhai: "",
    DtlNgaysinh: "",
    DtlNoisinh: "",
    DtlMaKH: "",
    DtlHocbong:"",
    DtlDiemtrungbinh: ""
  }
  const [dtlUser, setDtlUser] = useState(dtlInitUser);

  // Hàm xử lý nút thêm mới
  const dtlHandleAddNew = ()=>{
    setDtlSinhVienAppOrEdit(true);
  }
  const dtlHandleClose=(param)=>{
    setDtlSinhVienAppOrEdit(param);
  }
  const dtlHandleSubmit =(param)=>{
    dtlGetAllUsers();
    setDtlSinhVienAppOrEdit(param);
  }
  const dtlHandleDelete=()=>{
    dtlGetAllUsers();
  }
  let dtlElementForm = dtlSinhVienAppOrEdit===true?
      <DtlSinhVienAppOrEdit renderUsers={dtlUser} 
                        onDtlClose={dtlHandleClose}
                        onDtlSubmitForm={dtlHandleSubmit}/>:"";
  

  return (
    <div className="container border my-3">
      <h1>Làm việc với MockApi</h1>
      <hr />
      <DtlSinhVienList  renderDtlSinhVienList={dtlSinhVienList} onDtlDelete={dtlHandleDelete}/>
      {/* Nút để kích hoạt thêm mới người dùng */}
      <button className='btn btn-primary' name='btnDtlThemMoi' onClick={dtlHandleAddNew}>Thêm mới</button>
      <hr />
        {dtlElementForm}
    </div>
  );
}

export default DtlApp;