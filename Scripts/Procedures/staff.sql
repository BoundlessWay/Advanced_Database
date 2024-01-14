USE CQ_CSDLNC_05

-- get_staff_name
GO
CREATE OR ALTER PROC get_staff_name (@staff_id INT) 
AS
BEGIN
	SELECT U.full_name
	FROM [user] U
	WHERE U.id = @staff_id
END
GO

--get_list_user_role_staff
GO
CREATE OR ALTER PROC get_list_user_role_staff (@branch_id INT)
AS
BEGIN
	SELECT U.*
	FROM [user] U INNER JOIN staff S ON S.user_id = U.id
	WHERE U.working_branch_id = @branch_id
END
GO
EXEC get_list_user_role_staff @branch_id = 1
GO

-- update_staff
CREATE OR ALTER PROC update_staff (
    @staff_id INT,
	@username VARCHAR(50),
    @password VARCHAR(300),
    @full_name NVARCHAR(150),
    @date_of_birth DATE,
    @email VARCHAR(50),
    @phone_number VARCHAR(40),
	@address VARCHAR(200), 
	@gender int
)
AS
BEGIN
    UPDATE [user]
    SET username = @username,
		password = @password,
        full_name = @full_name,
        date_of_birth = @date_of_birth,
        email = @email,
        phone_number = @phone_number,
		permanent_address = @address,
		gender =  @gender
    WHERE id = @staff_id;
END;
GO

EXEC update_staff @staff_id = 150003,
	@username = 'staff2',
	@password = 'password',
    @full_name = 'Staff2',
    @date_of_birth = '1990-01-01',
    @email = 'staff2@example.com',
    @phone_number = '0920471822',
	@address = '45683 Main Street', 
	@gender = 1
GO

-- create_staff
CREATE OR ALTER PROC add_staff
	@username VARCHAR(50),
    @password VARCHAR(300),
    @full_name NVARCHAR(150),
    @date_of_birth DATE,
    @phone_number VARCHAR(40),
    @email VARCHAR(50),
    @permanent_address NVARCHAR(200),
    @gender BIT,
    @working_branch_id INT
AS
BEGIN

    -- Chèn thông tin nhân viên vào bảng [user]
    INSERT INTO [user] (username, password, full_name, date_of_birth, phone_number, email, permanent_address, gender, working_branch_id)
    VALUES (@username, @password, @full_name, @date_of_birth, @phone_number, @email, @permanent_address, @gender, @working_branch_id);

    -- Lấy user_id của nhân viên vừa được thêm vào
    DECLARE @staff_user_id INT;
    SET @staff_user_id = SCOPE_IDENTITY();

    -- Chèn thông tin nhân viên vào bảng staff
    INSERT INTO staff (user_id, jon_position)
    VALUES (@staff_user_id, N'Lễ tân');

END;
GO
EXEC add_staff @username = 'staff3',
    @password = 'password',
    @full_name = 'Nguyen Van S',
    @date_of_birth = '1988-03-20',
    @phone_number = '092781923',
    @email = 'staff3@example.com',
    @permanent_address  = '456 Main Street',
    @gender = 1,
    @working_branch_id  = 1




	-- get_user_info_role_dentist
GO
CREATE OR ALTER PROC get_user_info_role_staff (@user_id INT)
AS
BEGIN
	SELECT U.*
	FROM [user] U
	WHERE U.id = @user_id
END
GO
EXEC get_user_info_role_staff @user_id = 150003
GO