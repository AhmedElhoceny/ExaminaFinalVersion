let ShowMore = () => {
    let ElementsNumber = document.querySelectorAll(".Body_2 .Content .ContentElement").length;
    let Rows = Math.ceil(ElementsNumber / 3);
    document.querySelector(".Body_2").style.height = ((Rows * 260) + 150).toString() + "px";
    document.querySelector(".Show_More").style.display = "none";
    document.querySelectorAll(".Body_2 .Content .ContentElement").forEach(element => {
        element.style.display = "flex";
    });
}

window.onscroll = () => {
    if (window.scrollY >= 400) {
        document.querySelector(".scrollUp").style.display = "block";
    } else if (window.scrollY < 400) {
        document.querySelector(".scrollUp").style.display = "none";
    }
}
let GoUp = () => {
    window.scroll({
        top: 0,
        left: 0,
        behavior: 'smooth'
    });
}
let Start = () => {
    window.scroll({
        top: 800,
        left: 0,
        behavior: 'smooth'
    });
}
let ShowContents = (x) => {
    document.querySelectorAll(".MyRight>div").forEach(Ele => {
        Ele.style.display = "none";
    });
    switch (x) {
        case 1:
            document.querySelector(".Readings").style.display = "flex";
            break;
        case 2:
            document.querySelector(".Videos").style.display = "flex";
            break;
        case 3:
            document.querySelector(".Sheets").style.display = "flex";
            break;
        case 4:
            document.querySelector(".Pictures").style.display = "flex";
            break;
        case 5:
            document.querySelector(".Exams").style.display = "flex";
            break;
        case 6:
            document.querySelector(".Projects").style.display = "flex";
            break;
        case 7:
            document.querySelector(".Grads").style.display = "flex";
            break;
        case 8:
            document.querySelector(".Members").style.display = "flex";
            break;
        default:
            break;
    }
}
let AddData = (x) => {
    document.querySelector(".place").style.display = "block";
    switch (x) {
        case 1:
            document.querySelector(".Readings form").style.display = "flex";
            break;
        case 2:
            document.querySelector(".Videos form").style.display = "flex";
            break;
        case 3:
            document.querySelector(".Sheets form").style.display = "flex";
            break;
        case 4:
            document.querySelector(".Pictures form").style.display = "flex";
            break;
        case 5:
            document.querySelector(".Exams form").style.display = "flex";
            break;
        case 6:
            document.querySelector(".Projects form").style.display = "flex";
            break;
        case 7:
            document.querySelector(".Grads form").style.display = "flex";
            break;
        case 8:
            document.querySelector(".Members form").style.display = "flex";
            break;
        default:
            break;
    }
}
let HidePlace = () => {
    document.querySelector(".place").style.display = "none";
    document.querySelectorAll(".MyRight div form").forEach(Ele => {
        Ele.style.display = "none";
    });
}
let ChangeView = (x) => {
    x.style.backgroundColor = "#C8DCC7";
    x.className = "Checked";
    document.querySelectorAll(".Checked p").forEach(element => {
        element.textContent = "Sent";
        element.style.fontSize = "30px";
        x.style.cursor = "auto";
    });
}
let RedirectCoursetoAction = () => {
    document.querySelector(".SelectControlledContent").style.display = "flex";
    document.querySelector(".placeholder").style.display = "block";
}
let ShowAddCourseForm = () => {
    document.querySelector(".LogIn").style.top = "150px";
    document.querySelector(".placeholder").style.display = "block";
}
let ShowPlace = () => {
    document.querySelector(".LogIn").style.top = "-3000px";
    document.querySelector(".placeholder").style.display = "none";
    document.querySelector(".SelectControlledContent").style.display = "none";
}
let SelectFun = (Element, Title) => {
    document.querySelectorAll(".ControllBar div").forEach(I => {
        I.className = "";
    });
    Element.className = "Choosen";
    document.querySelectorAll(".Visible").forEach(K => {
        K.classList.remove("Visible");
    });
    switch (Title) {
        case 'Students':
            document.querySelector(".Students").classList.add("Visible");
            break;
        case 'Courses':
            document.querySelector(".Courses").classList.add("Visible");
            break;
        case 'CoursesStudents':
            document.querySelector(".CoursesStudents").classList.add("Visible");
            break;
        case 'Exams':
            document.querySelector(".Exams").classList.add("Visible");
            break;
        case 'Grads':
            document.querySelector(".Grads").classList.add("Visible");
            break;
        case 'Pictures':
            document.querySelector(".Pictures").classList.add("Visible");
            break;
        case 'Project':
            document.querySelector(".Project").classList.add("Visible");
            break;
        case 'Readings':
            document.querySelector(".Readings").classList.add("Visible");
            break;
        case 'Sheets':
            document.querySelector(".Sheets").classList.add("Visible");
            break;
        case 'Video':
            document.querySelector(".Video").classList.add("Visible");
            break;
        default:
            break;
    }
}
let SeeAddForm = (text) => {
    switch (text) {
        case "Courses":
            document.querySelector(".CourseForm").style.top = "100px";
            document.querySelector(".PicturesForm").style.top = "-1000px";
            document.querySelector(".VideoForm").style.top = "-1000px";
            document.querySelector(".SheetsForm").style.top = "-1000px";
            document.querySelector(".ReadingsForm").style.top = "-1000px";
            document.querySelector(".GradsForm").style.top = "-1000px";
            document.querySelector(".StudentForm").style.top = "-1000px";
            document.querySelector(".ExamsForm").style.top = "-1000px";
            document.querySelector(".CoursesStudentsForm").style.top = "-1000px";
            document.querySelector(".ProjectForm").style.top = "-1000px";
            document.querySelector(".HiddenDiv").style.display = "block";
            console.log(document.querySelector(".CourseForm"));
            break;
        case "Students":
            document.querySelector(".StudentForm").style.top = "100px";
            document.querySelector(".PicturesForm").style.top = "-1000px";
            document.querySelector(".GradsForm").style.top = "-1000px";
            document.querySelector(".SheetsForm").style.top = "-1000px";
            document.querySelector(".ReadingsForm").style.top = "-1000px";
            document.querySelector(".VideoForm").style.top = "-1000px";
            document.querySelector(".ExamsForm").style.top = "-1000px";
            document.querySelector(".CourseForm").style.top = "-1000px";
            document.querySelector(".CoursesStudentsForm").style.top = "-1000px";
            document.querySelector(".ProjectForm").style.top = "-1000px";
            document.querySelector(".HiddenDiv").style.display = "block";
            console.log(document.querySelector(".CourseForm"));
            break;
        case "CoursesStudents":
            document.querySelector(".CoursesStudentsForm").style.top = "100px";
            document.querySelector(".PicturesForm").style.top = "-1000px";
            document.querySelector(".GradsForm").style.top = "-1000px";
            document.querySelector(".SheetsForm").style.top = "-1000px";
            document.querySelector(".ReadingsForm").style.top = "-1000px";
            document.querySelector(".ProjectForm").style.top = "-1000px";
            document.querySelector(".ExamsForm").style.top = "-1000px";
            document.querySelector(".StudentForm").style.top = "-1000px";
            document.querySelector(".CourseForm").style.top = "-1000px";
            document.querySelector(".VideoForm").style.top = "-1000px";
            document.querySelector(".HiddenDiv").style.display = "block";
            console.log(document.querySelector(".CourseForm"));
            break;
        case "Exams":
            document.querySelector(".ExamsForm").style.top = "100px";
            document.querySelector(".PicturesForm").style.top = "-1000px";
            document.querySelector(".ReadingsForm").style.top = "-1000px";
            document.querySelector(".GradsForm").style.top = "-1000px";
            document.querySelector(".VideoForm").style.top = "-1000px";
            document.querySelector(".CoursesStudentsForm").style.top = "-1000px";
            document.querySelector(".StudentForm").style.top = "-1000px";
            document.querySelector(".SheetsForm").style.top = "-1000px";
            document.querySelector(".CourseForm").style.top = "-1000px";
            document.querySelector(".ProjectForm").style.top = "-1000px";
            document.querySelector(".HiddenDiv").style.display = "block";
            console.log(document.querySelector(".CourseForm"));
            break;
        case "Grads":
            document.querySelector(".GradsForm").style.top = "100px";
            document.querySelector(".ReadingsForm").style.top = "-1000px";
            document.querySelector(".ProjectForm").style.top = "-1000px";
            document.querySelector(".PicturesForm").style.top = "-1000px";
            document.querySelector(".ExamsForm").style.top = "-1000px";
            document.querySelector(".SheetsForm").style.top = "-1000px";
            document.querySelector(".CoursesStudentsForm").style.top = "-1000px";
            document.querySelector(".StudentForm").style.top = "-1000px";
            document.querySelector(".CourseForm").style.top = "-1000px";
            document.querySelector(".VideoForm").style.top = "-1000px";
            document.querySelector(".HiddenDiv").style.display = "block";
            console.log(document.querySelector(".CourseForm"));
            break;
        case "Pictures":
            document.querySelector(".PicturesForm").style.top = "100px";
            document.querySelector(".ProjectForm").style.top = "-1000px";
            document.querySelector(".VideoForm").style.top = "-1000px";
            document.querySelector(".SheetsForm").style.top = "-1000px";
            document.querySelector(".GradsForm").style.top = "-1000px";
            document.querySelector(".ReadingsForm").style.top = "-1000px";
            document.querySelector(".ExamsForm").style.top = "-1000px";
            document.querySelector(".CoursesStudentsForm").style.top = "-1000px";
            document.querySelector(".StudentForm").style.top = "-1000px";
            document.querySelector(".CourseForm").style.top = "-1000px";
            document.querySelector(".HiddenDiv").style.display = "block";
            console.log(document.querySelector(".CourseForm"));
            break;
        case "Project":
            document.querySelector(".ProjectForm").style.top = "100px";
            document.querySelector(".PicturesForm").style.top = "-1000px";
            document.querySelector(".SheetsForm").style.top = "-1000px";
            document.querySelector(".GradsForm").style.top = "-1000px";
            document.querySelector(".VideoForm").style.top = "-1000px";
            document.querySelector(".ExamsForm").style.top = "-1000px";
            document.querySelector(".ReadingsForm").style.top = "-1000px";
            document.querySelector(".CoursesStudentsForm").style.top = "-1000px";
            document.querySelector(".StudentForm").style.top = "-1000px";
            document.querySelector(".CourseForm").style.top = "-1000px";
            document.querySelector(".HiddenDiv").style.display = "block";
            console.log(document.querySelector(".CourseForm"));
            break;
        case "Readings":
            document.querySelector(".ReadingsForm").style.top = "100px";
            document.querySelector(".SheetsForm").style.top = "-1000px";
            document.querySelector(".VideoForm").style.top = "-1000px";
            document.querySelector(".ProjectForm").style.top = "-1000px";
            document.querySelector(".PicturesForm").style.top = "-1000px";
            document.querySelector(".GradsForm").style.top = "-1000px";
            document.querySelector(".ExamsForm").style.top = "-1000px";
            document.querySelector(".CoursesStudentsForm").style.top = "-1000px";
            document.querySelector(".StudentForm").style.top = "-1000px";
            document.querySelector(".CourseForm").style.top = "-1000px";
            document.querySelector(".HiddenDiv").style.display = "block";
            console.log(document.querySelector(".CourseForm"));
            break;
        case "Sheets":
            document.querySelector(".SheetsForm").style.top = "100px";
            document.querySelector(".ReadingsForm").style.top = "-1000px";
            document.querySelector(".ProjectForm").style.top = "-1000px";
            document.querySelector(".VideoForm").style.top = "-1000px";
            document.querySelector(".PicturesForm").style.top = "-1000px";
            document.querySelector(".GradsForm").style.top = "-1000px";
            document.querySelector(".ExamsForm").style.top = "-1000px";
            document.querySelector(".CoursesStudentsForm").style.top = "-1000px";
            document.querySelector(".StudentForm").style.top = "-1000px";
            document.querySelector(".CourseForm").style.top = "-1000px";
            document.querySelector(".HiddenDiv").style.display = "block";
            console.log(document.querySelector(".CourseForm"));
            break;
        case "Video":
            document.querySelector(".VideoForm").style.top = "100px";
            document.querySelector(".SheetsForm").style.top = "-1000px";
            document.querySelector(".ReadingsForm").style.top = "-1000px";
            document.querySelector(".ProjectForm").style.top = "-1000px";
            document.querySelector(".PicturesForm").style.top = "-1000px";
            document.querySelector(".GradsForm").style.top = "-1000px";
            document.querySelector(".ExamsForm").style.top = "-1000px";
            document.querySelector(".CoursesStudentsForm").style.top = "-1000px";
            document.querySelector(".StudentForm").style.top = "-1000px";
            document.querySelector(".CourseForm").style.top = "-1000px";
            document.querySelector(".HiddenDiv").style.display = "block";
            console.log(document.querySelector(".CourseForm"));
            break;
        default:
            break;
    }
}
let HideAddForm = () => {
    document.querySelector(".CourseForm").style.top = "-1000px";
    document.querySelector(".ReadingsForm").style.top = "-1000px";
    document.querySelector(".StudentForm").style.top = "-1000px";
    document.querySelector(".GradsForm").style.top = "-1000px";
    document.querySelector(".ExamsForm").style.top = "-1000px";
    document.querySelector(".VideoForm").style.top = "-1000px";
    document.querySelector(".SheetsForm").style.top = "-1000px";
    document.querySelector(".PicturesForm").style.top = "-1000px";
    document.querySelector(".ProjectForm").style.top = "-1000px";
    document.querySelector(".CoursesStudentsForm").style.top = "-1000px";
    document.querySelector(".HiddenDiv").style.display = "none";
}