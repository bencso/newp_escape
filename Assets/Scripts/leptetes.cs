using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leptetes : MonoBehaviour
{
 public static References Instance;
        private int currentPage = 0;
        private References refs;
        private GameObject[] pages;

        void Start()
        {
            refs = References.Instance;
            pages = new GameObject[4] { refs.Elso, refs.Ketto, refs.Harom, refs.Negy };
        }

        public void nextPage()
        {
            pages[currentPage].SetActive(false);
            pages[currentPage+1].SetActive(true);
            currentPage++;
        }

        public void prevPage()
        {
            pages[currentPage].SetActive(false);
            pages[currentPage-1].SetActive(true);
            currentPage--;
        }
}
