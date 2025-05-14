-- CreateTables.sql - Tạo cấu trúc bảng CSDL cho hệ thống quản lý nhân sự

	
	CREATE TABLE Leave (
    leaveID INT PRIMARY KEY,       -- Mã nghỉ phép (tự tăng)
    employeeID INT NOT NULL,                      -- Mã nhân viên (liên kết tới bảng Employee)
    startDate DATE NOT NULL,                      -- Ngày bắt đầu nghỉ
    endDate DATE NOT NULL,                        -- Ngày kết thúc nghỉ
    reason VARCHAR(255),                          -- Lý do nghỉ
    status VARCHAR(50) DEFAULT 'Pending',         -- Trạng thái (Pending, Approved, Rejected)

    -- Ràng buộc khóa ngoại liên kết đến bảng Employee
    FOREIGN KEY (employeeID) REFERENCES Employees(EmployeeID)
);


-- Bảng users đăng nhập
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,        -- Mật khẩu đã mã hóa (hash)
    FullName NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL CHECK (Role IN ('Admin', 'Employee')),  -- Phân quyền
    CreatedAt DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1                      -- 1: hoạt động, 0: bị khóa
);


-- Bảng phòng ban
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY IDENTITY(1,1),
    DepartmentName NVARCHAR(100) NOT NULL
);

-- Bảng chức vụ / bộ phận
CREATE TABLE Positions (
    PositionID INT PRIMARY KEY IDENTITY(1,1),
    PositionName NVARCHAR(100) NOT NULL
);

-- Bảng nhân viên
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    BirthDate DATE,
    Gender NVARCHAR(10),
    Address NVARCHAR(255),
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    DepartmentID INT,
    PositionID INT,
    HireDate DATE,
    IsProbation BIT,
    IsFired BIT DEFAULT 0,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID),
    FOREIGN KEY (PositionID) REFERENCES Positions(PositionID)
);

-- Bảng người dùng đăng nhập
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(20) NOT NULL, -- 'Admin' hoặc 'Employee'
    EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Bảng lương cơ bản và hệ số
CREATE TABLE Salaries (
    SalaryID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT,
    BaseSalary DECIMAL(18,2),
    Allowance DECIMAL(18,2),
    Bonus DECIMAL(18,2),
    Penalty DECIMAL(18,2),
    OvertimeHours INT,
    SalaryMonth INT,
    SalaryYear INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Bảng chấm công
CREATE TABLE Attendance (
    AttendanceID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT,
    WorkDate DATE,
    CheckIn TIME,
    CheckOut TIME,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Bảng khen thưởng
CREATE TABLE Rewards (
    RewardID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT,
    Reason NVARCHAR(255),
    RewardDate DATE,
    Amount DECIMAL(18,2),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Bảng kỷ luật
CREATE TABLE Disciplines (
    DisciplineID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT,
    Reason NVARCHAR(255),
    DisciplineDate DATE,
    Amount DECIMAL(18,2),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Bảng bảo hiểm
CREATE TABLE Insurance (
    InsuranceID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT,
    InsuranceType NVARCHAR(100),
    RegistrationDate DATE,
    ExpiryDate DATE,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Bảng tham số hệ thống
CREATE TABLE Parameters (
    ParameterID INT PRIMARY KEY IDENTITY(1,1),
    ParamName NVARCHAR(100),
    ParamValue NVARCHAR(100)
);
