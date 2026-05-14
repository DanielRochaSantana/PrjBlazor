SELECT * FROM dbo.Usuario 
WHERE 
Datacadastro < GETDATE() + 0.1 AND 
Datacadastro > GETDATE() - 0.1