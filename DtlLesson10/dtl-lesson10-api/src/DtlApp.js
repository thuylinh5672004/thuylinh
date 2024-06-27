
import './App.css';
import DtlListUsers from './components/DtlListUsers';
import axios from './api/dtlApi';
import{ useEffect,useState} from 'react';
function DtlApp() {
const [DtlListUsers,setDtlListUsers] = useState([]);
  // doc du lieu tu api
  const dtlGetAllUsers = async ()=>{
    const dtlResponse = await axios.get("dtlUsers")
    console.log("Api Data:",dtlResponse.data);
    setDtlListUsers(dtlResponse.data)
  }
  useEffect(()=>{
    dtlGetAllUsers();
    console.log("State Data:",DtlListUsers);
  },[])
  return (
    <div className="container border my-3">
      <h1> lam viec voi mockapi</h1>
      <hr/>
      <DtlListUsers renderDtlListUsers={DtlListUsers}/>
    </div>
  );
}

export default DtlApp;

