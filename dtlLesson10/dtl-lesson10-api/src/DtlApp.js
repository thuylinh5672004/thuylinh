import './App.css';
import DtlListUsers from './components/DtlListUsers';
import axios from './api/dtlApi';
import { useEffect, useState } from 'react';
import DtlFormAddOrEdit from './components/DtlFormAddOrEdit';

function DtlApp() {
  
  const [dtlListUsers, setDtlListUsers] = useState([]);

  // Hàm để gọi API và lấy dữ liệu
  const dtlGetAllUsers = async () => {
    try {
      const dtlResponse = await axios.get("dtlUsers");
      console.log("Dữ liệu từ API:", dtlResponse.data);
      setDtlListUsers(dtlResponse.data);
    } catch (error) {
      console.error("Lỗi khi lấy dữ liệu:", error);
    }
  };

  // useEffect để gọi dtlGetAllUsers khi component được mount (tương đương componentDidMount)
  useEffect(() => {
    dtlGetAllUsers();
    console.log("state Data:",dtlListUsers);
    
  }, [])
  const [dtlAddOrEdit, setDtlAddOrEdit] = useState(false);
  const dtlInitUser = {
    UserName: "Đào thị thùy linh",
    Password: "4/7/2004",
    Email: "thuylinh@gmail.com",
    Phone: "06788768",
    id: "2210900036"
  }
  const [dtlUser, setDtlUser] = useState(dtlInitUser);

  // Hàm xử lý nút thêm mới
  const dtlHandleAddNew = ()=>{
    setDtlAddOrEdit(true);
  }
  const dtlHandleClose=(param)=>{
    setDtlAddOrEdit(param);
  }
  const dtlHandleSubmit =(param)=>{
    dtlGetAllUsers();
    setDtlAddOrEdit(param);
  }
  const dtlHandleDelete=()=>{
    dtlGetAllUsers();
  }
  let dtlElementForm = dtlAddOrEdit===true?
      <DtlFormAddOrEdit renderUsers={dtlUser} 
                        onDtlClose={dtlHandleClose}
                        onDtlSubmitForm={dtlHandleSubmit}/>:"";
  

  return (
    <div className="container border my-3">
      <h1>Làm việc với MockApi</h1>
      <hr />
      <DtlListUsers  renderDtlListUsers={dtlListUsers} onDtlDelete={dtlHandleDelete}/>
      {/* Nút để kích hoạt thêm mới người dùng */}
      <button className='btn btn-primary' name='btnDtlThemMoi' onClick={dtlHandleAddNew}>Thêm mới</button>
      <hr />
        {dtlElementForm}
    </div>
  );
}

export default DtlApp;