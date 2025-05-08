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
- **Giao diện**: WinForms
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
├── src/                            # Mã nguồn chính của ứng dụng
│   ├── Common/                     # Chứa các lớp và chức năng chung (Utilities, Helpers)
│   ├── Data/                       # Chứa lớp dữ liệu (Data Access Layer)
│   │   ├── ADO/                    # Lớp ADO.NET
│   │   │   ├── AdoEmployee.cs      # Quản lý nhân viên (Employee)
│   │   │   ├── AdoDepartment.cs    # Quản lý phòng ban (Department)
│   │   │   ├── AdoPosition.cs      # Quản lý chức vụ (Position)
│   │   │   ├── AdoContract.cs      # Quản lý hợp đồng (Contract)
│   │   │   ├── AdoSalary.cs        # Quản lý lương (SalaryRecord)
│   │   │   ├── AdoIncomeStatistics.cs # Quản lý thống kê thu nhập (IncomeStatistics)
│   │   ├── EF/                     # Lớp Entity Framework
│   │   │   ├── EfEmployee.cs       # Quản lý nhân viên (Employee)
│   │   │   ├── EfDepartment.cs     # Quản lý phòng ban (Department)
│   │   │   ├── EfPosition.cs       # Quản lý chức vụ (Position)
│   │   │   ├── EfContract.cs       # Quản lý hợp đồng (Contract)
│   │   │   ├── EfSalary.cs         # Quản lý lương (SalaryRecord)
│   │   │   ├── EfIncomeStatistics.cs # Quản lý thống kê thu nhập (IncomeStatistics)
│   │   ├── Database/               # Các lớp quản lý kết nối cơ sở dữ liệu (DB Connection)
│   │   │   ├── DatabaseHelper.cs    # Quản lý kết nối chung cho cả ADO.NET và EF
│   │
│   ├── Business/                   # Lớp logic nghiệp vụ (Business Logic Layer)
│   │   ├── EmployeeManager.cs       # Quản lý logic nhân viên
│   │   ├── DepartmentManager.cs     # Quản lý logic phòng ban
│   │   ├── PositionManager.cs       # Quản lý logic chức vụ
│   │   ├── ContractManager.cs       # Quản lý logic hợp đồng
│   │   ├── SalaryManager.cs         # Quản lý logic lương
│   │   ├── IncomeStatisticsManager.cs # Quản lý logic thống kê thu nhập
│   │
│   ├── UI/                          # Giao diện người dùng (User Interface)
│   │   ├── EmployeeForm.cs          # Form quản lý nhân viên
│   │   ├── DepartmentForm.cs        # Form quản lý phòng ban
│   │   ├── PositionForm.cs          # Form quản lý chức vụ
│   │   ├── ContractForm.cs          # Form quản lý hợp đồng
│   │   ├── SalaryForm.cs            # Form quản lý lương
│   │   ├── IncomeStatisticsForm.cs  # Form thống kê thu nhập
│   │
│   ├── App/                         # Chứa các thành phần ứng dụng (Chạy ứng dụng)
│   │   ├── Program.cs               # Điểm khởi đầu của ứng dụng
│   │   ├── AppSettings.cs           # Cấu hình ứng dụng
│
├── Database/                        # Chứa các tệp cơ sở dữ liệu (SQL scripts)
│   ├── DatabaseScript.sql           # Tạo cơ sở dữ liệu và bảng dữ liệu mẫu
│
├── Docs/                            # Tài liệu liên quan đến dự án
│   ├── Readme.md                    # Hướng dẫn cài đặt và sử dụng dự án
│   ├── DatabaseDesign.md             # Thiết kế cơ sở dữ liệu
│   ├── ProjectRoadmap.md             # Lộ trình phát triển dự án
│
├── .gitignore                       # Các tệp và thư mục cần bỏ qua khi sử dụng Git
├── CompanyHRManagement.sln          # Tệp giải pháp Visual Studio
├── README.md                        # Tóm tắt dự án và thông tin cài đặt
└── LICENSE                          # Giấy phép sử dụng mã nguồn


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
- GitHub: [github.com/your-team]

