using System;
using Battlehub.SplineEditor;
using UnityEngine;

namespace _Scripts
{
    public struct Route
    {
        public Route(SplineBase spline, GameObject routeArrow, string sceneryName, int distance, int etaMins,
            Vector3 destPos)
        {
            this.spline = spline;
            this.routeArrow = routeArrow;
            this.sceneryName = sceneryName;
            this.distance = distance;
            ETAMins = etaMins;
            this.destPos = destPos;
            image = null;
        }

        //精灵的进行路线
        private SplineBase spline;

        //路线的对应箭头
        private GameObject routeArrow;

        //目的景点的名字
        private String sceneryName;

        //目的景点的距离,单位为米
        private int distance;

        //预计到达时间,单位为分钟
        private int ETAMins;

        //目标点坐标
        private Vector3 destPos;

        //目的景点的图片
        private Sprite image;

        public string SceneryName
        {
            get { return sceneryName; }
            set { sceneryName = value; }
        }

        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public int EtaMins
        {
            get { return ETAMins; }
            set { ETAMins = value; }
        }

        public Vector3 DestPos
        {
            get { return destPos; }
            set { destPos = value; }
        }

        public SplineBase Spline
        {
            get { return spline; }
            set { spline = value; }
        }

        public GameObject RouteArrow
        {
            get { return routeArrow; }
            set { routeArrow = value; }
        }

        public int EtaMins1
        {
            get { return ETAMins; }
            set { ETAMins = value; }
        }

        public Sprite Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}