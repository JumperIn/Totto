var gulp = require("gulp"),
    fs = require("fs"),
    babel = require("gulp-babel"),
    cssmin = require('gulp-cssmin'),
    gulpif = require('gulp-if'),
    argv = require('yargs').argv,
    stylus = require("gulp-stylus"),
    gutil = require('gulp-util'),
    concat = require('gulp-concat'),
    livereload = require('gulp-livereload');

// пути исходников
var source = 'src';

// сюда указываем пути у подключаемых библиотек
var libsCss = [
    `./${source}/libs/styles/bootstrap-grid.min.css`,
    `./${source}/libs/styles/fontawesome/fontawesome-all.min.css`,
    `./${source}/libs/styles/fontawesome/fontawesome.min.css`,
    `./${source}/libs/styles/fontawesome/fa-brands.min.css`,
    `./${source}/libs/styles/fontawesome/fa-regular.min.css`,
    `./${source}/libs/styles/fontawesome/fa-solid.min.css`
];

var webfonts = `./${source}/libs/styles/fontawesome/webfonts/**`;

// сюда указываем пути у подключаемых библиотек
var libsJs = [
    `./${source}/libs/scripts/jquery.min.js`
];

var srcPaths = {
    stylus: [`./${source}/css/site.styl`],
    img: [`./${source}/img/**`],
    icons: [`./${source}/icons/**`],
    js: [`./${source}/scripts/*.js`],
    favicon: [`./${source}/favicon.ico`],
    fonts: [`./${source}/fonts/**`],
    webfonts: webfonts,
    libsCss: libsCss,
    libsJs: libsJs,
    allStylus: [`./${source}/css/*.styl`]
}

// пути для сборки
var destination = 'wwwroot';
var destPaths = {
    css: `./${destination}/css`,
    img: `./${destination}/images`,
    icons: `./${destination}/icons`,
    js: `./${destination}/js`,
    favicon: `./${destination}`,
    fonts: `./${destination}/fonts`,
    webfonts: `./${destination}/libs/webfonts`,
    libFolderJs: `./${destination}/libs/scripts`,
    libFileJs: 'script.js',
    libFolderCss: `./${destination}/libs/styles`,
    libFileCss: 'style.css'
}

var production = argv.production !== undefined || argv.prod !== undefined;

// сборка стилей
gulp.task("stylus", function () {
    return gulp.src(srcPaths.stylus)
        .pipe(stylus())
        .pipe(gulp.dest(destPaths.css));
});

// сборка скриптов
gulp.task("js", function () {
    gulp.src(srcPaths.js)
        .pipe(babel({
            presets: [[
                'env', {
                    "targets": {
                        "browsers": [
                            "Chrome >= 52",
                            "FireFox >= 44",
                            "Safari >= 7",
                            "Explorer 11",
                            "last 4 Edge versions"
                        ]
                    },
                    "useBuiltIns": true
                }
            ]]
        }))
        .pipe(gulp.dest(destPaths.js));
});

// копирование ресурсов
gulp.task('copy', function () {
    gulp.src(srcPaths.icons)
        .pipe(gulp.dest(destPaths.icons));
    gulp.src(srcPaths.img)
        .pipe(gulp.dest(destPaths.img));
    gulp.src(srcPaths.fonts)
        .pipe(gulp.dest(destPaths.fonts));
    gulp.src(srcPaths.webfonts)
        .pipe(gulp.dest(destPaths.webfonts));
});

gulp.task('libs', function () {
    gulp.src(srcPaths.libsJs)
        .pipe(concat(destPaths.libFileJs))
        .pipe(gulp.dest(destPaths.libFolderJs));

    gulp.src(srcPaths.libsCss)
        .pipe(concat(destPaths.libFileCss))
        .pipe(gulp.dest(destPaths.libFolderCss));
});

gulp.task('favicon', function () {
    gulp.src(srcPaths.favicon)
        .pipe(gulp.dest(destPaths.favicon));
})

gulp.task('watch', function () {
    livereload.listen();
    gulp.watch(
        [...srcPaths.allStylus, ...srcPaths.js, ...srcPaths.icons, ...srcPaths.img, ...srcPaths.libsJs, ...srcPaths.libsCss],
        [ 'stylus', 'js', 'copy', 'libs' ])
        .on('change', livereload.changed);
});

gulp.task('default', [
    'copy',
    'libs',
    'js',
    'stylus',
    'favicon'
]);
