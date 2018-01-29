#include "StdAfx.h"
#include "TriangleMesh.h"
#include "Physics.h"
#include "Serializable.h"
#include "RefCountedAlignedMemory.h"

#include <PxTriangleMesh.h> 

TriangleMesh::TriangleMesh(PxTriangleMesh* triangleMesh, PhysX::Physics^ physics)
{
	if (triangleMesh == NULL)
		throw gcnew ArgumentNullException("triangleMesh");
	ThrowIfNull(physics, "physics");

	_triangleMesh = triangleMesh;
	_physics = physics;
	_memoryBlock = 0;
}

TriangleMesh::TriangleMesh(PxTriangleMesh* triangleMesh, PhysX::Physics^ physics, RefCountedAlignedMemory* memoryBlock)
{
	if (triangleMesh == NULL)
		throw gcnew ArgumentNullException("triangleMesh");
	ThrowIfNull(physics, "physics");

	_triangleMesh = triangleMesh;
	_physics = physics;
	_memoryBlock = memoryBlock;
	_memoryBlock->addRef();
}

TriangleMesh::~TriangleMesh()
{
	this->!TriangleMesh();
}
TriangleMesh::!TriangleMesh()
{
	OnDisposing(this, nullptr);

	if (this->Disposed)
		return;

	_triangleMesh->release();
	_triangleMesh = NULL;

	_physics = nullptr;

	if (_memoryBlock != 0) {
		_memoryBlock->decRef();
		_memoryBlock = 0;
	}

	OnDisposed(this, nullptr);
}
bool TriangleMesh::Disposed::get()
{
	return (_triangleMesh == NULL);
}

PhysX::Physics^ TriangleMesh::Physics::get()
{
	return _physics;
}

Serializable^ TriangleMesh::AsSerializable()
{
	return gcnew Serializable(_triangleMesh);
}

array<Vector3>^ TriangleMesh::GetVertices()
{
	return Util::AsManagedArray<Vector3>((void*)_triangleMesh->getVertices(), _triangleMesh->getNbVertices());
}
int TriangleMesh::NumberOfVertices::get()
{
	return _triangleMesh->getNbVertices();
}

array<int>^ TriangleMesh::GetTriangles()
{
	return Util::AsManagedArray<int>((void*)_triangleMesh->getTriangles(), _triangleMesh->getNbTriangles());
}
int TriangleMesh::NumberOfTriangles::get()
{
	return _triangleMesh->getNbTriangles();
}
bool TriangleMesh::Has16BitTriangleIndices::get()
{
	return _triangleMesh->has16BitTriangleIndices();
}

array<int>^ TriangleMesh::GetTriangleRemap()
{
	return Util::AsManagedArray<int>((void*)_triangleMesh->getTrianglesRemap(), _triangleMesh->getNbTriangles());
}

int TriangleMesh::ReferenceCount::get()
{
	return _triangleMesh->getReferenceCount();
}

short TriangleMesh::GetTriangleMaterialIndex(int triangleIndex)
{
	return _triangleMesh->getTriangleMaterialIndex(triangleIndex);
}

PxTriangleMesh* TriangleMesh::UnmanagedPointer::get()
{
	return _triangleMesh;
}