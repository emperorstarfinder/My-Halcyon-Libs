#include "StdAfx.h"
#include "SQLiteTransaction.h"

namespace wcvfs
{
	SQLiteTransaction::SQLiteTransaction(SQLiteConnection::ptr dbConn)
	: _committed(false), _dbConn(dbConn)
	{
		_dbConn->queryWithNoResults("BEGIN TRANSACTION;");
	}

	SQLiteTransaction::~SQLiteTransaction()
	{
		if (! _committed) {
			_dbConn->queryWithNoResults("ROLLBACK;");
		}
	}

	void SQLiteTransaction::commit()
	{
		_dbConn->queryWithNoResults("COMMIT;");
		_committed = true;
	}
}