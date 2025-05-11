# 🧩 Hệ Thống Quản Lý Nhân Sự Công Ty (Company Human Resource Management System)

## 📌 Mô tả dự án
Đây là một phần mềm quản lý nhân sự dành cho công ty, hỗ trợ quản lý thông tin nhân viên, phòng ban, lương thưởng và thống kê thu nhập.  
Hệ thống được phát triển bằng ngôn ngữ **C# WinForms**, sử dụng hai phương pháp truy xuất dữ liệu:

- **Phiên bản 1**: Sử dụng **ADO.NET**
- **Phiên bản 2**: Sử dụng **Entity Framework (EF)**

Ứng dụng tuân theo kiến trúc **3 lớp (3-tier architecture)**:
- **GUI Layer**: Giao diện người dùng (WinForms)
- **BUS Layer**: Xử lý nghiệp vụ
- **DAL Layer**: Truy xuất dữ liệu (ADO.NET / EF)

---

## 🎯 Tính năng chính

### 1. Chức năng quản lý
- Thêm / sửa / xóa thông tin nhân viên, phòng ban, chức vụ
- Quản lý bảng lương, hợp đồng, hệ số lương

### 2. Chức năng tính toán
- Tính lương nhân viên (lương cơ bản + phụ cấp - khấu trừ)
- Tính tổng thu nhập trong tháng, quý, năm

### 3. Chức năng tìm kiếm
- Tìm kiếm nhân viên theo mã, tên, phòng ban, địa chỉ...

### 4. Thống kê – báo cáo
- Thống kê thu nhập nhân viên theo năm
- Thống kê số lượng nhân viên theo phòng ban
- Biểu đồ trực quan hóa (sử dụng biểu đồ trong WinForms)

### 5. Các chức năng nâng cao
- Đăng nhập và phân quyền (Admin / Nhân viên)
- Xuất báo cáo Excel / PDF (tuỳ chọn)
- Tự động cập nhật trạng thái hợp đồng hết hạn

---

## 🔧 Công nghệ sử dụng

- **Ngôn ngữ**: C# (.NET Framework)
- **Giao diện**: thư viện Guna.UI2.WinForms
- **Database**: SQL Server
- **ADO.NET & Entity Framework**
- **Crystal Reports / Chart Control (thống kê)**

---

## 🧠 Phân chia công việc (3 thành viên)

| Thành viên | Vai trò | Nhiệm vụ |
|------------|---------|----------|
| **Thành viên 1** | Trưởng nhóm + Giao diện | - Thiết kế giao diện người dùng (WinForms)<br> - Điều hướng Form<br> - Kết nối GUI với tầng nghiệp vụ |
| **Thành viên 2** | Backend – Dữ liệu | - Thiết kế cơ sở dữ liệu<br> - Xây dựng tầng truy xuất dữ liệu (DAL) cho ADO.NET và EF<br> - Tạo Stored Procedure |
| **Thành viên 3** | Backend – Nghiệp vụ | - Xử lý tính lương, thống kê, tìm kiếm<br> - Viết tầng nghiệp vụ (BUS)<br> - Kết nối dữ liệu với giao diện |

---

## 🗂 Cấu trúc thư mục đề xuất

CompanyHRManagement/
│
├── GUI/ → Giao diện người dùng (WinForms)
├── BUS/ → Xử lý nghiệp vụ
├── DAL_ADO/ → Truy xuất dữ liệu bằng ADO.NET
├── DAL_EF/ → Truy xuất dữ liệu bằng Entity Framework
├── Models/ → Các lớp đối tượng (POCO classes)
├── Reports/ → Báo cáo thống kê
├── DatabaseScript.sql → File tạo CSDL
└── README.md

* Chi tiết cấu trúc:
CompanyHRManagement/
│
├── GUI/                        # Giao diện WinForms
│   ├── frmLogin.cs
│   ├── frmDashboard.cs
│   ├── frmEmployee.cs
│   ├── frmAttendance.cs
│   ├── frmSalary.cs
│   └── frmStatistics.cs
│
├── BUS/                        # Xử lý nghiệp vụ
│   ├── EmployeeBUS.cs
│   ├── AttendanceBUS.cs
│   └── SalaryBUS.cs
│
├── DAL_ADO/                    # ADO.NET (Version 1)
│   ├── DBConnection.cs
│   ├── EmployeeDAO.cs
│   ├── AttendanceDAO.cs
│   └── SalaryDAO.cs
│
├── DAL_EF/                     # Entity Framework (Version 2)
│   ├── AppDbContext.cs
│   ├── EmployeeRepository.cs
│   └── AttendanceRepository.cs
│
├── Models/                     # Định nghĩa các lớp thực thể
│   ├── Employee.cs
│   ├── Attendance.cs
│   └── Salary.cs
│
├── Reports/                    # Báo cáo RDLC / Xuất Excel
│   └── EmployeeStatisticsReport.rdlc
│
├── Scripts/                    # SQL khởi tạo + dữ liệu mẫu
│   └── InitDatabase.sql
│
├── Resources/                  # Icon, ảnh, logo,...
│
├── README.md                   # Mô tả dự án
├── .gitignore
└── Program.cs

* Nâng cấp:
* CompanyHRManagement/
│
├── GUI/                            # Giao diện người dùng (WinForms)
│   ├── Login/                      # Form đăng nhập, loading, phân quyền
│   │   └── LoginForm.cs
│   │   └── SplashScreen.cs
│   │   └── ChangePasswordForm.cs
│   │
│   ├── Employee/                   # Quản lý nhân sự, nhân viên, thử việc, bị đuổi
│   │   └── EmployeeListForm.cs
│   │   └── ProbationForm.cs
│   │   └── FiredEmployeeForm.cs
│   │
│   ├── Department/                # Quản lý phòng ban, bộ phận
│   │   └── DepartmentForm.cs
│   │   └── DivisionForm.cs
│   │
│   ├── Payroll/                   # Lương, chấm công, khen thưởng, kỷ luật
│   │   └── AttendanceForm.cs
│   │   └── SalaryForm.cs
│   │   └── BonusForm.cs
│   │   └── DisciplineForm.cs
│   │   └── SalaryCalculationForm.cs
│   │   └── SalaryIncreaseForm.cs
│   │
│   ├── Reports/                   # Báo cáo thống kê
│   │   └── EmployeeStatsChart.cs
│   │   └── SearchForm.cs
│   │
│   ├── System/                    # Quản lý tài khoản, tham số hệ thống
│   │   └── UserManagementForm.cs
│   │   └── ParameterSettingsForm.cs
│   │
│   └── MainForm.cs                # Giao diện chính sau đăng nhập
│
├── BUS/                            # Business Logic Layer
│   ├── AuthenticationBUS.cs
│   ├── EmployeeBUS.cs
│   ├── DepartmentBUS.cs
│   ├── PayrollBUS.cs
│   ├── ReportBUS.cs
│   ├── UserBUS.cs
│   └── Utils/                     # Tiện ích như mã hóa mật khẩu
│       └── EncryptionUtil.cs
│
├── DAL_ADO/                        # Data Access Layer - ADO.NET
│   ├── DBConnection.cs
│   ├── EmployeeDAO.cs
│   ├── DepartmentDAO.cs
│   ├── PayrollDAO.cs
│   ├── UserDAO.cs
│   ├── AttendanceDAO.cs
│   └── ...
│
├── DAL_EF/                         # Data Access Layer - Entity Framework
│   ├── AppDbContext.cs
│   ├── Repositories/
│   │   ├── EmployeeRepository.cs
│   │   ├── DepartmentRepository.cs
│   │   ├── PayrollRepository.cs
│   │   └── UserRepository.cs
│   └── Migrations/
│
├── Models/                         # Lớp POCO (thực thể dữ liệu)
│   ├── Employee.cs
│   ├── Department.cs
│   ├── Attendance.cs
│   ├── Salary.cs
│   ├── Bonus.cs
│   ├── Discipline.cs
│   ├── User.cs
│   └── ...
│
├── Reports/                        # File .rdlc hoặc báo cáo Excel
│   └── IncomeStatistics.rdlc
│   └── ExportUtils.cs
│
├── Resources/                      # Icon, ảnh, file cấu hình
│
├── .gitignore                      # Bỏ qua .vs, bin, obj, ...
├── README.md                       # Mô tả dự án, phân công thành viên
└── Program.cs                      # Entry point




---

## ✅ Yêu cầu triển khai

- [x] Phát triển 2 phiên bản (ADO.NET và EF)
- [x] Áp dụng kiến trúc 3 tầng rõ ràng
- [x] Dùng chung giao diện cho cả 2 phiên bản
- [x] Thực hiện tìm kiếm, thống kê và tính toán trong nghiệp vụ
- [ ] Tối ưu và đóng gói báo cáo (RDLC hoặc Crystal Reports)

---

## 📅 Tiến độ đề xuất

| Tuần | Công việc |
|------|-----------|
| Tuần 1 | Thiết kế CSDL, giao diện, chia task |
| Tuần 2 | Làm phiên bản ADO.NET |
| Tuần 3 | Chuyển sang phiên bản EF |
| Tuần 4 | Thống kê, hoàn thiện báo cáo, kiểm thử |

---

## 📬 Liên hệ nhóm

- Trưởng nhóm: [MinhCHuong] – Email: chuongminh3225@gmail.com
- GitHub: https://github.com/chuongminh32/Company-human-resource-management

