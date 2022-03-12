-- --------------------------------------------------------
-- Servidor:                     localhost
-- Versão do servidor:           10.4.16-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando dados para a tabela codigo_penal_cda.CriminalCode: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `CriminalCode` DISABLE KEYS */;
INSERT INTO `CriminalCode` (`Id`, `Name`, `Description`, `Penalty`, `PrisionTime`, `StatusId`, `CreateDate`, `UpdateDate`, `CreateUserId`, `UpdateUserId`) VALUES
	(3, 'string', 'string', 0, 0, 1, '2019-01-06 17:16:40', '2019-01-06 17:16:40', 1, 1),
	(4, 'string', 'string', 0, 0, 1, '2019-01-06 17:16:40', '2019-01-06 17:16:40', 1, NULL),
	(5, 'string', 'string', 15, 0, 1, '2019-01-06 17:16:40', NULL, 1, NULL),
	(6, 'string', 'string', 15, 5, 1, '2019-01-06 17:16:40', NULL, 1, NULL);
/*!40000 ALTER TABLE `CriminalCode` ENABLE KEYS */;

-- Copiando dados para a tabela codigo_penal_cda.Status: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `Status` DISABLE KEYS */;
INSERT INTO `Status` (`Id`, `Name`) VALUES
	(1, 'Status Teste');
/*!40000 ALTER TABLE `Status` ENABLE KEYS */;

-- Copiando dados para a tabela codigo_penal_cda.User: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `User` DISABLE KEYS */;
INSERT INTO `User` (`Id`, `UserName`, `Password`) VALUES
	(1, 'alt', '4d48fba6cf5f7d6abfb35e695f453297870a7a56568ceae968f06d04701b0047');
/*!40000 ALTER TABLE `User` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
