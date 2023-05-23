import React, { Fragment, useState } from 'react';
import axios from 'axios';

function Registration()
{
    const [phoneNo,setPhoneNo] = useState("");
    const [firstName,setFirstName] = useState("");
    const [lastName,setLastName] = useState("");
    const [password,setPassword] = useState("");
    const [email,setEmail] = useState("");
    const [status,setStatus] = useState("");

    const handlePhoneNoChange = (value)=>{
        setPhoneNo(value);
    }

    const handleFirstNameChange = (value)=>{
        setFirstName(value);
    }

    const handleLastNameChange = (value)=>{
        setLastName(value);
    }

    const handlePasswordChange = (value)=>{
        setPassword(value);
    }

    const handleEmailChange = (value)=>{
        setEmail(value);
    }

    const handleStatusChange = (value)=>{
        setStatus(value);
    }

    const handleSave = ()=>{
        const data = {
            ID         : phoneNo,
            FirstName  : firstName,
            LastName   : lastName,
            Password   : password,
            Email      : email,
            Status     : status
        }

        // const url = 'https://localhost:44316/api/Users/'+phoneNo;
        // axios.put(url,data).then((result)=>{
        //     if(result.data !== null)
        //     alert("User Added sucessfully....");
        //     else
        //     alert("Something went wrong....");
        // }).catch((error)=>{
        //     alert(error);
        // })

        const url = 'https://localhost:44316/api/Users/1';
        axios.get(url).then((result)=>{
            if(result.data !== null)
            alert("User Added sucessfully....");
            else
            alert("Something went wrong....");
        }).catch((error)=>{
            alert(error);
        })


    }




    return(
        <Fragment>
            <div>Registration</div>
            <label>PhoneNo</label>
            <input type="number" id="txtPhoneNo" placeholder="Enter Phone Number" onChange={(e)=> handlePhoneNoChange(e.target.value)}></input><br/><br/>
            <label>FirstName</label>
            <input type="text" id="txtFirstName" placeholder="Enter First Name" onChange={(e)=> handleFirstNameChange(e.target.value)}></input><br/><br/>
            <label>LastName</label>
            <input type="text" id="txtLastName" placeholder="Enter Last Name" onChange={(e)=> handleLastNameChange(e.target.value)}></input><br/><br/>
            <label>Password</label>
            <input type="text" id="txtPassword" placeholder="Enter Password" onChange={(e)=> handlePasswordChange(e.target.value)}></input><br/><br/>
            <label>Email</label>
            <input type="text" id="txtEmail" placeholder="Enter Email" onChange={(e)=> handleEmailChange(e.target.value)}></input><br/><br/>
            <label>Status</label>
            <input type="number" id="txtStatus" placeholder="Enter Status" onChange={(e)=> handleStatusChange(e.target.value)}></input><br/><br/>
            <button onClick={() => handleSave()}>Register</button>
        </Fragment>
    )
}

export default Registration;

