#pragma once

#include <stdexcept>

namespace wcvfs
{
	class IndexFileError : public std::runtime_error
	{
	public:
		IndexFileError(const std::string& message);
		virtual ~IndexFileError() throw();
	};

}
