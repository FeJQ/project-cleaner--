#include "MyFile.h"
#include <vector>
#include <io.h>
#include <fstream>


MyFile::MyFile()
{
}


MyFile::~MyFile()
{
}


//文件路径列表
vector<string> files;

/// <summary>
/// 获取指定路径下的所有文件
/// </summary>
/// <param name="path">指定路径</param>
/// <param name="list">文件列表</param>
/// <return>若成功,返回所有文件完整路径(用|隔开)</return>
char* MyFile::getAllFiles(string path)
{	
	//文件句柄
	long hFile = 0;
	//文件信息
	struct _finddata_t fileinfo;  //很少用的文件信息读取结构
	string p;  //string类很有意思的一个赋值函数:assign()，有很多重载版本
	if ((hFile = _findfirst(p.assign(path).append("\\*").c_str(), &fileinfo)) != -1) {
		do {
			if ((fileinfo.attrib & _A_SUBDIR)) {  //比较文件类型是否是文件夹
				if (strcmp(fileinfo.name, ".") != 0 && strcmp(fileinfo.name, "..") != 0) {
					files.push_back(p.assign(path).append("\\").append(fileinfo.name));
					getAllFiles(p.assign(path).append("\\").append(fileinfo.name));
				}
			}
			else {
				files.push_back(p.assign(path).append("\\").append(fileinfo.name));
			}
		} while (_findnext(hFile, &fileinfo) == 0);  //寻找下一个，成功返回0，否则-1
		_findclose(hFile);
	}
	return 0;
}

