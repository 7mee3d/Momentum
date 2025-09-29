# 🌟 Momentum - To-Do List Application 📋

> **Momentum** is a clean, intuitive, and beginner-friendly to-do list application built for **programming practice** and **personal productivity**.  
> Easily add, complete, delete, and save your tasks — all through a sleek, user-friendly interface! 💻✨

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D7?style=for-the-badge&logo=windows&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)

---

<img width="1235" height="737" alt="Screenshot 2025-09-29 200452" src="https://github.com/user-attachments/assets/84b0975b-b6df-4ba0-8e0a-033a43ba369e" />

*The main interface — simple, clear, and effective!*

---

## 📌 Project Overview

**Momentum** was developed as a hands-on training project to master the fundamentals of **GUI programming using C# and Windows Forms**.  
It’s not just about making an app that works — it’s about applying core programming principles like:
- Separation of logic and UI
- Error handling
- Data persistence
- Smooth user experience

---

## ✨ Full Feature List

| Feature | Description | Emoji |
|--------|-------------|-------|
| **Add New Task** | Type your task and click "Add" | ➕ |
| **Duplicate Prevention** | Prevents adding tasks that already exist | ⚠️ |
| **Mark as Complete** | Click any task to toggle ✔️ (completed/incomplete) | ✅ |
| **Delete Selected Task** | Remove a specific task from the list | 🗑️ |
| **Smart Empty-List Alerts** | Warns you if you try to delete from an empty list | ❗ |
| **Delete All Tasks** | Clear the entire list with one click | 🧹 |
| **Check/Uncheck All** | Mark or unmark all tasks at once | 🔘 |
| **Save to File** | Export your to-do list to `InformationTO_DOList.txt` | 💾 |
| **Live Task Counter** | Shows completed vs. pending tasks in real time | 📊 |
| **Minimalist UI** | Clean yellow-and-white theme, zero clutter | 🎨 |

---

## 🛡️ Smart Alert System

To prevent user errors and enhance experience, Momentum includes intelligent validation messages:

- ❗ **Empty input**:  
  > "Please enter a task description!"

- ⚠️ **Duplicate task**:  
  > "This task already exists in the list!"

- 🚫 **Delete from empty list**:  
  > "The list is already empty!"

- 🚫 **Delete all when empty**:  
  > "The list is already empty!"


> All alerts appear as clear, non-intrusive **MessageBox popups**.

---

## 🖼️ Screenshots

### 1. Main Application Window
![Main Screen](assets/Screenshot%202025-09-29%20194253.png)

### 2. Example Task List in Action
![Task List Example](assets/image.png)

> 💡 *No database used — all data is stored locally in a plain text file for simplicity and learning purposes.*

---

## 🧩 UI Elements Explained

| Element | Function |
|--------|----------|
| **Text Input Field** | Enter your new task description |
| **Add Button** | Adds the task (with duplicate & empty checks) |
| **Task ListBox** | Displays all tasks; click to toggle completion |
| **Remove Task Button** | Deletes the selected task (with empty-list alert) |
| **Remove All Task Button** | Clears the entire list (with confirmation logic) |
| **Checked All Tasks Button** | Marks all tasks as completed |
| **Unchecked All Tasks Button** | Removes completion marks from all tasks |
| **Save TO-DO List In File Button** | Saves tasks to `tasks.txt` |
| **Completed Task Counter** | Shows number of finished tasks |
| **Pending Task Counter** | Shows number of remaining tasks |

---

## 🚀 How to Run

### Prerequisites
- OS: Windows (with .NET Framework support)
- IDE: Visual Studio (optional, for development)

### Steps
1. **Clone the repository**:
   
   ```bash
   git clone https://github.com/your-username/Momentum.git
   cd Momentum
   ```
2. **Run the executable (if available)**:
   
    ```bash
    Go to bin/Debug or bin/Release
    Launch Momentum.exe
    ```
3. **Build from source**:
   
   ```bash
    Open Momentum.sln in Visual Studio
    Press Ctrl + Shift + B to build
    Press Ctrl + F5 to run
    ```
   
 ---
## 💾 Data Persistence

Clicking "Save TO-DO List In File" saves all tasks to InformationTO_DOList.txt in the app’s directory.
Each task appears on a new line, with ✓ prepended to completed tasks.
Auto-load on startup is not implemented (as this is a training project), but can be added easily!

---

## 🛠️ Technologies Used
- Language: C#
- Framework: .NET Framework (Windows Forms)
- IDE: Visual Studio 2022
- Version Control: Git + GitHub
- UI: Custom-designed, no external libraries

---

## 🌱 Future Enhancements
- Auto-load tasks on app startup
- Add due dates to tasks 📅
- Task categories (Work, Study, Personal) 🏷️
- Export to PDF or Excel 📤
- Multi-language support (including Arabic) 🌍
- Dark Mode 🌙

---

# 👨💻 Author

**Ahmed Jehad Ahmed**  


🔗 [GitHub Profile](https://github.com/7mee3d)

📧 [Email Contact](mailto:enginnerahemdjehad2004@gmail.com)
