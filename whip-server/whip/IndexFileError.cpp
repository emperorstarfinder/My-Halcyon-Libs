#include "StdAfx.h"
#include "IndexFileError.h"

namespace wcvfs
{
	IndexFileError::IndexFileError(const std::string& message)
	: std::runtime_error(message)
	{
	}

	IndexFileError::~IndexFileError() throw()
	{
	}
}
