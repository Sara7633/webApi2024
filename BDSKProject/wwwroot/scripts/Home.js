const callServer = async () => {
    try {
        const res = await fetch("User")
        if (!res.ok)
            throw new Error("error in fetching data")
        const data = await res.json()
        alert(data)
    }
    catch (ex) {
        alert(ex)
    }
}
//const register = async () => {
//    try {
//        const passColor = document.getElementById("passwordColor")
//        if (passColor.style.getPropertyValue("background-color") != "green") {
//            throw Error("password not strong")
//        }
//        const username = document.getElementById("txtUsername").value
//        const password = document.getElementById("password").value
//        const firstName = document.getElementById("txtFirstName").value
//        const lastName = document.getElementById("txtLastName").value
//        const email = document.getElementById("txtEmail").value
//        if (!username || !password) {
//            throw Error("username and password required")
//        }
//        const user = {
//            username, password, firstName, lastName,email
//        }
//        const res = await fetch("api/User/register", {
//            method: "POST",
//            body: JSON.stringify(user),
//            headers: {
//                'Content-Type': 'application/json'
//            }

//        })
//        if (res.ok) {
//            const data = await res.json()

//            alert("נרשמת בהצלחה למערכת") 
//            localStorage.setItem("id", data.id)
//            window.location.replace("Products.html")
//        }

//        else alert("error")
//    }
//    catch (err) {
//        alert(err)
//    }
//}
const register = async () => {
    try {
        const passColor = document.getElementById("passwordColor");
        const username = document.getElementById("txtUsername").value.trim();
        const password = document.getElementById("password").value.trim();
        const firstName = document.getElementById("txtFirstName").value.trim();
        const lastName = document.getElementById("txtLastName").value.trim();
        const email = document.getElementById("txtEmail").value.trim();

        // Check if username and password are provided
        if (!username || !password) {
            throw new Error("Username and password are required");
        }

        // Check password strength
        if (passColor.style.getPropertyValue("background-color") != "green") {
            throw new Error("Password strength is not sufficient");
        }

        // Validate email format
        if (email && !validateEmail(email)) {
            throw new Error("Invalid email format");
        }

        const user = {
            username,
            password,
            firstName,
            lastName,
            email
        };

        const res = await fetch("api/User/register", {
            method: "POST",
            body: JSON.stringify(user),
            headers: {
                'Content-Type': 'application/json'
            }
        });

        if (res.ok) {
            const data = await res.json();
            localStorage.setItem("id", data.id);
            alert("נרשמת בהצלחה למערכת");
            window.location.replace("Products.html");
        } else {
            throw new Error("Registration failed");
        }
    } catch (err) {
        alert(err.message);
    }
}

function validateEmail(email) {
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailRegex.test(email);
}
const login = async () => {
        try {
            const username = document.getElementById("txtName").value
            const password = document.getElementById("txtPassword").value
            const user = {
                username, password
            }
            const res = await fetch("api/User/login", {
                method: "POST",
                body: JSON.stringify(user),
                headers: {
                    'Content-Type': 'application/json'
                }

            })

            if (res.ok) {
                const data =await res.json()
                localStorage.setItem("id", data.id)
                window.location.replace("Products.html")
            }
            else alert("incorrect username or password")

        }
        catch (error) {
            alert(error)
        }
}


const checkPassword = async() => {
    try {
        const password = document.getElementById("password").value
        const passColor = document.getElementById("passwordColor")
        const res = await fetch("api/User/password", {
            method: "POST",
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(password)
        })
        if (res.ok) {
            const data = await res.json()
            if (data == 0) {
                passColor.style.setProperty("background-color", "red")
            }
            else if (data < 2) {
                passColor.style.setProperty("background-color", "orange")
            }

            else {
                passColor.style.setProperty("background-color", "green")
            } 
                

        }
        else alert("incorrect username or password")
       
        
    } catch (e) {
        alert(e)
    }   
}
const update = async () => {
    try {
      

        const id =JSON.parse(localStorage.getItem("id"));
        const username = document.getElementById("txtUsernameUp").value
        const password = document.getElementById("password").value
        const firstName = document.getElementById("txtFirstNameUp").value
        const lastName = document.getElementById("txtLastNameUp").value
        const email = document.getElementById("txtEmail").value

        if (!username || !password) {
            throw Error("username and password required")
        }
        const user = {
            username, password, firstName, lastName,email
        }
        
        const res = await fetch(`api/User/${id}`, {
            method: "PUT",
            body: JSON.stringify(user),
            headers: {
                'Content-Type': 'application/json'
            }

        })
        if (res.ok) {
            alert("עודכן")
            window.location.replace("Products.html")
        }
        console.log(res)
    }
    catch (err) {
        alert(err)
    }
    
}