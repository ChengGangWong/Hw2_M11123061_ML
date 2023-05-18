from PIL import Image
import numpy as np
import os
def GetYAxisMax(path):
    y=Image.open(path)
    yArray=np.array(y.convert("L"))
    yMax=0
    for row in range(0,len(yArray)):
        for col in range(0,len(yArray[row])):
            if (yArray[row][col]!=0):
                yMax=row
                break
    return yMax

def MinusAbsolute(y,g):
    yMax=GetYAxisMax(y)
    gMax=GetYAxisMax(g)
    return abs(yMax-gMax)

def AvgError(yPath,yReduce,gPath,gReduce,pxTocm):
    sum=0
    count=0
    yList=os.listdir(yPath)
    gList=os.listdir(gPath)
    for y in yList:
        yName=y.replace(yReduce,"")
        for g in gList:            
            gName=g.replace(gReduce,"")
            if yName==gName:
                sum=sum+MinusAbsolute(yPath+'\\'+y,gPath+'\\'+g)
                count=count+1
                break
    return sum/count/pxTocm
def MinImg(yPath,yReduce,gPath,gReduce):
    sum=0
    count=0
    yList=os.listdir(yPath)
    gList=os.listdir(gPath)
    minC=999
    minName=''
    for y in yList:
        yName=y.replace(yReduce,"")
        for g in gList:            
            gName=g.replace(gReduce,"")
            if yName==gName:
                if(MinusAbsolute(yPath+'\\'+y,gPath+'\\'+g)<minC):
                    minName=yName
                    minC=MinusAbsolute(yPath+'\\'+y,gPath+'\\'+g)
                break
    return minName

def Acc(yPath,yReduce,gPath,gReduce,pxTocm,divide):
    count=0
    i=0
    yList=os.listdir(yPath)
    gList=os.listdir(gPath)
    for y in yList:
        yName=y.replace(yReduce,"")
        for g in gList:            
            gName=g.replace(gReduce,"")
            if yName==gName:
                if MinusAbsolute(yPath+'\\'+y,gPath+'\\'+g)<=(pxTocm/divide):
                    i=i+1
                count=count+1
                break
    return i/count*100

