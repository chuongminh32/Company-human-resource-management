Các thực thể chính trong hệ thống:
Employee (Nhân viên)

1. EmployeeID (PK)

FullName

DateOfBirth

Gender

Email

Phone

DepartmentID (FK)

Position

HireDate

SalaryID (FK)

2. Department (Phòng ban)

DepartmentID (PK)

DepartmentName

DepartmentHead (FK - EmployeeID)

3. Salary (Lương)

SalaryID (PK)

BaseSalary

Allowance

Bonus

Penalty

OvertimeHours

SalaryMonth

SalaryYear

EmployeeID (FK)

4. Attendance (Chấm công)

AttendanceID (PK)

EmployeeID (FK)

Date

CheckInTime

CheckOutTime

OvertimeHours

AbsenceStatus

5. Reward (Khen thưởng)

RewardID (PK)

EmployeeID (FK)

RewardType

Amount

RewardDate

6. Discipline (Kỷ luật)

DisciplineID (PK)

EmployeeID (FK)

DisciplineType

Amount

DisciplineDate

7. User (Tài khoản người dùng)

UserID (PK)

Username

PasswordHash

Role (Admin, Employee)

8. Parameter (Tham số hệ thống)

ParameterID (PK)

ParameterName

ParameterValue

Mối quan hệ giữa các thực thể:
Employee - Department: Một nhân viên thuộc một phòng ban. Quan hệ many-to-one từ Employee đến Department.

Employee - Salary: Một nhân viên có một bản ghi lương. Quan hệ one-to-one giữa Employee và Salary.

Employee - Attendance: Một nhân viên có nhiều bản ghi chấm công. Quan hệ one-to-many từ Employee đến Attendance.

Employee - Reward: Một nhân viên có thể nhận nhiều khen thưởng. Quan hệ one-to-many từ Employee đến Reward.

Employee - Discipline: Một nhân viên có thể bị kỷ luật nhiều lần. Quan hệ one-to-many từ Employee đến Discipline.

User - Employee: Tài khoản người dùng có thể thuộc một nhân viên cụ thể. Quan hệ one-to-one giữa User và Employee.

Employee - Reward/Discipline: Một nhân viên có thể nhận nhiều khen thưởng hoặc kỷ luật.

ERD Mô tả:
+----------------+        +----------------+        +----------------+
|   Employee     |        |   Department   |        |     Salary     |
|----------------|        |----------------|        |----------------|
| EmployeeID (PK)|<------>| DepartmentID(PK)|<------>| SalaryID (PK)  |
| FullName       |        | DepartmentName |        | BaseSalary     |
| DateOfBirth    |        | DepartmentHead |        | Allowance      |
| Gender         |        |                |        | Bonus          |
| Email          |        +----------------+        | Penalty        |
| Phone          |                                  | OvertimeHours  |
| DepartmentID   |                                  | EmployeeID(FK) |
| Position       |                                  +----------------+
| HireDate       |
| SalaryID(FK)   |
+----------------+
       |
       | 
       v
+----------------+        +----------------+        +----------------+
|   Attendance   |        |     Reward     |        |   Discipline   |
|----------------|        |----------------|        |----------------|
| AttendanceID(PK)|       | RewardID (PK)  |        | DisciplineID (PK)|
| EmployeeID(FK) |<------>| EmployeeID(FK) |        | EmployeeID(FK)  |
| Date           |        | RewardType     |        | DisciplineType  |
| CheckInTime    |        | Amount         |        | Amount          |
| CheckOutTime   |        | RewardDate     |        | DisciplineDate  |
| OvertimeHours  |        +----------------+        +----------------+
| AbsenceStatus  |
+----------------+

+----------------+
|      User      |
|----------------|
| UserID (PK)    |
| Username       |
| PasswordHash   |
| Role           |
+----------------+

+----------------+
|   Parameter    |
|----------------|
| ParameterID (PK)|
| ParameterName  |
| ParameterValue |
+----------------+

* Giải thích: 
Employee: Lưu thông tin nhân viên.

Department: Lưu thông tin phòng ban và quản lý các phòng ban.

Salary: Lưu thông tin lương của nhân viên, bao gồm các thành phần như lương cơ bản, phụ cấp, thưởng, kỷ luật, giờ tăng ca, v.v.

Attendance: Lưu thông tin chấm công hàng ngày của nhân viên.

Reward: Quản lý các khen thưởng nhân viên nhận được.

Discipline: Quản lý các hình thức kỷ luật đối với nhân viên.

User: Quản lý thông tin tài khoản người dùng, có thể là admin hoặc nhân viên.

Parameter: Quản lý các tham số hệ thống, ví dụ như hệ số lương, phúc lợi, v.v.