package com.example.ffernandezz.reciclerviewdemo;

/**
 * Created by ffernandezz on 26/01/2016.
 */
public class MyItem {
    String title;
    String artist;
    int image;

    public MyItem(String title,String artist, int image){
        this.title=title;
        this.artist=artist;
        this.image=image;
    }

    public String getTitle(){
        return title;
    }

    public String getArtist(){
        return artist;
    }

    public int getImage(){
        return image;
    }


}
