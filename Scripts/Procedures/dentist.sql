USE CQ_CSDLNC_05

-- get_dentist_name
GO
CREATE OR ALTER PROC get_dentist_name (@dentist_id INT) 
AS
BEGIN
	SELECT U.full_name
	FROM [user] U
	WHERE U.id = @dentist_id
END
GO

--get_list_user_role_dentist
GO
CREATE OR ALTER PROC get_list_user_role_dentist (@branch_id INT)
AS
BEGIN
	SELECT U.*
	FROM [user] U INNER JOIN dentist D ON D.user_id = U.id
	WHERE U.working_branch_id = @branch_id
END
GO
EXEC get_list_user_role_dentist @branch_id = 1
GO

-- update_dentist
CREATE OR ALTER PROC update_dentist (
    @dentist_id INT,
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
    SET 
		username = @username,
		password = @password,
        full_name = @full_name,
        date_of_birth = @date_of_birth,
        email = @email,
        phone_number = @phone_number,
		permanent_address = @address,
		gender =  @gender
    WHERE id = @dentist_id;
END;
GO
EXEC update_dentist @dentist_id = 150001,
	@username = 'dentist1',
    @password = 'password',
    @full_name = 'Dentist1',
    @date_of_birth = '1951-07-10',
    @email = 'dentist1@gmail.com',
    @phone_number = '(419)570-9217x045',
	@address = '1917 Kevin Lock Apt. 297 North Michaelton, HI 90283', 
	@gender = 0
GO

-- create_dentist
CREATE OR ALTER PROC add_dentist
	@username VARCHAR(50),
    @password VARCHAR(300),
    @full_name NVARCHAR(150),
    @date_of_birth DATE,
    @phone_number VARCHAR(40),
    @email VARCHAR(50),
    @permanent_address NVARCHAR(200),
    @gender BIT,
    @working_branch_id INT,
	@medical_practice_certificate_code VARCHAR(50)
AS
BEGIN

    -- Chèn thông tin nha sĩ vào bảng [user]
    INSERT INTO [user] (username, password, full_name, date_of_birth, phone_number, email, permanent_address, gender, working_branch_id)
    VALUES (@username, @password, @full_name, @date_of_birth, @phone_number, @email, @permanent_address, @gender, @working_branch_id);

    -- Lấy user_id của nha sĩ vừa được thêm vào
    DECLARE @dentist_user_id INT;
    SET @dentist_user_id = SCOPE_IDENTITY();

    -- Chèn thông tin nha sĩ vào bảng dentist
    INSERT INTO dentist (user_id, medical_practice_certificate_code )
    VALUES (@dentist_user_id, @medical_practice_certificate_code);

END;

GO


EXEC add_dentist @username = 'dentist6',
    @password = 'password',
    @full_name = 'Nguyen Van C',
    @date_of_birth = '1988-03-20',
    @phone_number = '987654421',
    @email = 'dentist6@example.com',
    @permanent_address  = '456 Main Street',
    @gender = 1,
    @working_branch_id  = 1,
	@medical_practice_certificate_code = 'niu182e8122'


-- get_user_info_role_dentist
GO
CREATE OR ALTER PROC get_user_info_role_dentist (@user_id INT)
AS
BEGIN
	SELECT U.*
	FROM [user] U
	WHERE U.id = @user_id
END
GO
EXEC get_user_info_role_dentist @user_id = 150001
GO

exec add_dentist @username=N'dentist3',@password=N'password',@full_name=N'Dentist3',@date_of_birth='2024-01-14 07:55:12.470',@phone_number=N'0828391294',@email=N'dentist3@gmail.com',@permanent_address=N''
,@gender=1,@working_branch_id=1,@medical_practice_certificate_code=N'djasu1s2'

select * from dentist D where d.user_id = 150007